using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Data.SqlClient;

namespace Proyecto_Taller_Grupo_22
{
    public partial class ReporteE : Form
    {
        public ReporteE()
        {
            InitializeComponent();
        }

        private void ReporteE_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView para las ventas
            dgvproductos.Columns.Add("FechaVenta", "Fecha Venta");
            dgvproductos.Columns.Add("Cliente", "Cliente");
            dgvproductos.Columns.Add("Vendedor", "Vendedor");
            dgvproductos.Columns.Add("Producto", "Producto");
            dgvproductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvproductos.Columns.Add("Cantidad", "Cantidad");
            dgvproductos.Columns.Add("Subtotal", "Subtotal");
            dgvproductos.Columns.Add("TotalVenta", "Total Venta");
        }

        private void GenerarR_Click(object sender, EventArgs e)
        {
            dgvproductos.Rows.Clear();
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT v.fecha_venta, p.nombre + ' ' + p.apellido AS Cliente, 
                                u.nombre_usuario AS Vendedor, pr.nombre_producto AS Producto, 
                                pr.precio_venta AS PrecioUnitario, dv.cantidad, 
                                dv.subtotal, v.total_venta AS TotalVenta
                                FROM Venta v
                                INNER JOIN Cliente c ON v.id_cliente = c.id_cliente
                                INNER JOIN Persona p ON c.id_cliente = p.id_persona
                                INNER JOIN Usuario u ON v.id_usuario = u.id_usuario
                                INNER JOIN Detalle_Venta dv ON v.id_venta = dv.id_venta
                                INNER JOIN Producto pr ON dv.id_producto = pr.id_producto
                                WHERE v.fecha_venta BETWEEN @fechaInicio AND @fechaFin
                                AND u.id_usuario = @IDUsuario"; // Filtro por usuario logueado

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);
                command.Parameters.AddWithValue("@IDUsuario", UsuarioInfo.IDUsuario); // Pasar el ID del usuario logueado

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dgvproductos.Rows.Add(
                        reader["fecha_venta"],
                        reader["Cliente"],
                        reader["Vendedor"],
                        reader["Producto"],
                        reader["PrecioUnitario"],
                        reader["cantidad"],
                        reader["subtotal"],
                        reader["TotalVenta"]
                    );
                }

                reader.Close();
            }
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("ReporteVentas_{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.PlantillaR.ToString();
            string filas = string.Empty;
            decimal totalGeneral = 0;

            // Construir las filas de productos para el HTML
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                // Asegurarse de que la fila no esté vacía
                if (row.Cells["Producto"].Value != null)
                {
                    filas += "<tr>";
                    filas += "<td>" + (row.Cells["FechaVenta"].Value != null ? Convert.ToDateTime(row.Cells["FechaVenta"].Value).ToString("dd/MM/yyyy") : "") + "</td>";
                    filas += "<td>" + (row.Cells["Cliente"].Value != null ? row.Cells["Cliente"].Value.ToString() : "") + "</td>";
                    filas += "<td>" + (row.Cells["Vendedor"].Value != null ? row.Cells["Vendedor"].Value.ToString() : "") + "</td>";
                    filas += "<td>" + (row.Cells["Producto"].Value != null ? row.Cells["Producto"].Value.ToString() : "") + "</td>";
                    filas += "<td>" + (row.Cells["PrecioUnitario"].Value != null ? Convert.ToDecimal(row.Cells["PrecioUnitario"].Value).ToString("$#,##0.00") : "") + "</td>";
                    filas += "<td>" + (row.Cells["Cantidad"].Value != null ? row.Cells["Cantidad"].Value.ToString() : "") + "</td>";
                    filas += "<td>" + (row.Cells["Subtotal"].Value != null ? Convert.ToDecimal(row.Cells["Subtotal"].Value).ToString("$#,##0.00") : "") + "</td>";
                    filas += "<td>" + (row.Cells["TotalVenta"].Value != null ? Convert.ToDecimal(row.Cells["TotalVenta"].Value).ToString("$#,##0.00") : "") + "</td>";
                    filas += "</tr>";

                    // Sumar el valor del TotalVenta al total general
                    if (row.Cells["TotalVenta"].Value != null)
                    {
                        totalGeneral += Convert.ToDecimal(row.Cells["TotalVenta"].Value);
                    }
                }
            }

            // Reemplazar en la plantilla los datos generados
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_GENERAL", totalGeneral.ToString("$#,##0.00"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHAINICIO", dtpFechaInicio.Value.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHAFIN", dtpFechaFin.Value.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            // Guardar el PDF
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    // Insertar imagen en el PDF
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    // Agregar el contenido HTML al PDF
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("Reporte PDF generado correctamente.");
            }
        }


    }
}
