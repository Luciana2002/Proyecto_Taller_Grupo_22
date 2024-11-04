using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_Grupo_22
{
    public partial class ReporteG : Form
    {
        public ReporteG()
        {
            InitializeComponent();
        }

        private string tipoReporte = "";

        private void btnMayorRecaudacion_Click(object sender, EventArgs e)
        {
            tipoReporte = "mayorRecaudacion";
            dgvReporte.Columns.Clear();

            dgvReporte.Columns.Add("Empleado", "Empleado");
            dgvReporte.Columns.Add("VentasRealizadas", "Ventas Realizadas");
            dgvReporte.Columns.Add("TotalRecaudado", "Total Recaudado");

            dgvReporte.Columns["Empleado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReporte.Columns["VentasRealizadas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReporte.Columns["TotalRecaudado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Formateo para mostrar solo dos decimales en la columna "TotalRecaudado"
            dgvReporte.Columns["TotalRecaudado"].DefaultCellStyle.Format = "N2";

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT CONCAT(p.nombre, ' ', p.apellido) AS Empleado,
                                COUNT(v.id_venta) AS VentasRealizadas,
                                SUM(v.total_venta) AS TotalRecaudado
                         FROM Venta v
                         JOIN Usuario u ON v.id_usuario = u.id_usuario
                         JOIN Persona p ON u.id_usuario = p.id_persona
                         WHERE v.fecha_venta BETWEEN @FechaInicio AND @FechaFin
                         GROUP BY p.nombre, p.apellido
                         ORDER BY TotalRecaudado DESC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaInicio", dtpFechaInicio.Value);
                command.Parameters.AddWithValue("@FechaFin", dtpFechaFin.Value);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvReporte.Rows.Add(reader["Empleado"], reader["VentasRealizadas"],
                    Convert.ToDecimal(reader["TotalRecaudado"]).ToString("N2"));
                }
                reader.Close();
            }
        }

        private void btnProductosMasVendidos_Click(object sender, EventArgs e)
        {
            tipoReporte = "productosMasVendidos";
            dgvReporte.Columns.Clear();

            if (dgvReporte.Columns.Count == 0)
            {
                dgvReporte.Columns.Add("Producto", "Producto");
                dgvReporte.Columns.Add("CantidadVendida", "Cantidad Vendida");
                dgvReporte.Columns.Add("PrecioCosto", "Precio Costo");
                dgvReporte.Columns.Add("CostoTotal", "Costo Total");
                dgvReporte.Columns.Add("PrecioVenta", "Precio Venta");
                dgvReporte.Columns.Add("RecaudacionTotal", "Recaudación Total");

                dgvReporte.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["CantidadVendida"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["PrecioCosto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["CostoTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["PrecioVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["RecaudacionTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Formato para mostrar solo dos decimales en las columnas de precios y totales
                dgvReporte.Columns["PrecioCosto"].DefaultCellStyle.Format = "N2";
                dgvReporte.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
                dgvReporte.Columns["CostoTotal"].DefaultCellStyle.Format = "N2";
                dgvReporte.Columns["RecaudacionTotal"].DefaultCellStyle.Format = "N2";
            }

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT p.nombre_producto AS Producto,
                                SUM(dv.cantidad) AS CantidadVendida,
                                p.precio_costo AS PrecioCosto,
                                SUM(p.precio_costo * dv.cantidad) AS CostoTotal,
                                p.precio_venta AS PrecioVenta,
                                SUM(p.precio_venta * dv.cantidad) AS RecaudacionTotal
                         FROM Producto p
                         JOIN Detalle_Venta dv ON p.id_producto = dv.id_producto
                         JOIN Venta v ON dv.id_venta = v.id_venta
                         WHERE v.fecha_venta BETWEEN @FechaInicio AND @FechaFin
                         GROUP BY p.nombre_producto, p.precio_costo, p.precio_venta
                         ORDER BY CantidadVendida DESC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaInicio", dtpFechaInicio.Value);
                command.Parameters.AddWithValue("@FechaFin", dtpFechaFin.Value);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string producto = reader["Producto"].ToString();
                    int cantidadVendida = (int)reader["CantidadVendida"];
                    double precioCosto = (double)reader["PrecioCosto"];
                    double costoTotal = (double)reader["CostoTotal"];
                    double precioVenta = (double)reader["PrecioVenta"];
                    double recaudacionTotal = (double)reader["RecaudacionTotal"];

                    dgvReporte.Rows.Add(
                        producto,
                        cantidadVendida,
                        precioCosto.ToString("F2"),
                        costoTotal.ToString("F2"),
                        precioVenta.ToString("F2"),
                        recaudacionTotal.ToString("F2")
                    );
                }
                reader.Close();
            }
        }

        private void btnTodasVentas_Click(object sender, EventArgs e)
        {
            tipoReporte = "todasVentas";
            dgvReporte.Columns.Clear();

            if (dgvReporte.Columns.Count == 0)
            {
                dgvReporte.Columns.Add("FechaVenta", "Fecha de Venta");
                dgvReporte.Columns.Add("Cliente", "Cliente");
                dgvReporte.Columns.Add("Vendedor", "Vendedor");
                dgvReporte.Columns.Add("Producto", "Producto");
                dgvReporte.Columns.Add("PrecioUnitario", "Precio Unitario");
                dgvReporte.Columns.Add("Cantidad", "Cantidad");
                dgvReporte.Columns.Add("Subtotal", "Subtotal");
                dgvReporte.Columns.Add("TotalVenta", "Total de Venta");

                // Ajustar el tamaño de las columnas
                dgvReporte.Columns["FechaVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Vendedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["TotalVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Formato para mostrar solo dos decimales en las columnas de precios y totales
                dgvReporte.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
                dgvReporte.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
                dgvReporte.Columns["TotalVenta"].DefaultCellStyle.Format = "N2";
            }

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT v.fecha_venta AS FechaVenta,
                                p.nombre + ' ' + p.apellido AS Cliente,
                                u.nombre_usuario AS Vendedor,
                                pr.nombre_producto AS Producto, 
                                pr.precio_venta AS PrecioUnitario,
                                dv.cantidad,
                                dv.subtotal,
                                v.total_venta AS TotalVenta
                         FROM Venta v
                         INNER JOIN Cliente c ON v.id_cliente = c.id_cliente
                         INNER JOIN Persona p ON c.id_cliente = p.id_persona
                         INNER JOIN Usuario u ON v.id_usuario = u.id_usuario
                         INNER JOIN Detalle_Venta dv ON v.id_venta = dv.id_venta
                         INNER JOIN Producto pr ON dv.id_producto = pr.id_producto
                         WHERE v.fecha_venta BETWEEN @FechaInicio AND @FechaFin";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaInicio", dtpFechaInicio.Value);
                command.Parameters.AddWithValue("@FechaFin", dtpFechaFin.Value);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvReporte.Rows.Add(
                        Convert.ToDateTime(reader["FechaVenta"]).ToShortDateString(),
                        reader["Cliente"].ToString(),
                        reader["Vendedor"].ToString(),
                        reader["Producto"].ToString(),
                        Convert.ToDecimal(reader["PrecioUnitario"]).ToString("N2"),
                        Convert.ToInt32(reader["cantidad"]),
                        Convert.ToDecimal(reader["subtotal"]).ToString("N2"),
                        Convert.ToDecimal(reader["TotalVenta"]).ToString("N2")
                    );
                }
                reader.Close();
            }
        }

        private void BBuscarE_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario de búsqueda de empleados
            BuscarEmpleadoForm buscarEmpleado = new BuscarEmpleadoForm();

            // Mostrar el formulario de búsqueda como un cuadro de diálogo
            if (buscarEmpleado.ShowDialog() == DialogResult.OK)
            {
                // Recuperar los datos seleccionados en el formulario de búsqueda y asignarlos a los TextBox del formulario de ventas
                TEmpleadoID.Text = buscarEmpleado.IdEmpleadoSeleccionado;
                TEmpleadoNombre.Text = buscarEmpleado.NombreEmpleadoSeleccionado;
            }
        }

        private void btnTodasVentasVendedor_Click(object sender, EventArgs e)
        {
            tipoReporte = "todasVentasVendedor";
            dgvReporte.Columns.Clear();

            if (dgvReporte.Columns.Count == 0)
            {
                dgvReporte.Columns.Add("FechaVenta", "Fecha de Venta");
                dgvReporte.Columns.Add("Cliente", "Cliente");
                dgvReporte.Columns.Add("Producto", "Producto");
                dgvReporte.Columns.Add("PrecioUnitario", "Precio Unitario");
                dgvReporte.Columns.Add("Cantidad", "Cantidad");
                dgvReporte.Columns.Add("Subtotal", "Subtotal");
                dgvReporte.Columns.Add("TotalVenta", "Total de Venta");

                // Ajustar el tamaño de las columnas
                dgvReporte.Columns["FechaVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["TotalVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Formato para mostrar solo dos decimales en las columnas de precios y totales
                dgvReporte.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
                dgvReporte.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
                dgvReporte.Columns["TotalVenta"].DefaultCellStyle.Format = "N2";
            }

            string EmpleadoID = TEmpleadoID.Text;

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT v.fecha_venta AS FechaVenta,
                                p.nombre + ' ' + p.apellido AS Cliente,
                                pr.nombre_producto AS Producto, 
                                pr.precio_venta AS PrecioUnitario,
                                dv.cantidad,
                                dv.subtotal,
                                v.total_venta AS TotalVenta
                         FROM Venta v
                         INNER JOIN Cliente c ON v.id_cliente = c.id_cliente
                         INNER JOIN Persona p ON c.id_cliente = p.id_persona
                         INNER JOIN Usuario u ON v.id_usuario = u.id_usuario
                         INNER JOIN Detalle_Venta dv ON v.id_venta = dv.id_venta
                         INNER JOIN Producto pr ON dv.id_producto = pr.id_producto
                         WHERE v.fecha_venta BETWEEN @FechaInicio AND @FechaFin
                         AND u.id_usuario = @EmpleadoID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaInicio", dtpFechaInicio.Value);
                command.Parameters.AddWithValue("@FechaFin", dtpFechaFin.Value);
                command.Parameters.AddWithValue("@EmpleadoID", EmpleadoID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvReporte.Rows.Add(
                        Convert.ToDateTime(reader["FechaVenta"]).ToShortDateString(),
                        reader["Cliente"].ToString(),
                        reader["Producto"].ToString(),
                        Convert.ToDecimal(reader["PrecioUnitario"]).ToString("N2"),
                        Convert.ToInt32(reader["cantidad"]),
                        Convert.ToDecimal(reader["subtotal"]).ToString("N2"),
                        Convert.ToDecimal(reader["TotalVenta"]).ToString("N2")
                    );
                }
                reader.Close();
            }
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            // Establecer el nombre del archivo y seleccionar la plantilla según el tipo de reporte
            string nombreArchivo;
            string PaginaHTML_Texto;

            if (tipoReporte == "mayorRecaudacion")
            {
                nombreArchivo = "ReporteMayorRecaudacion";
                PaginaHTML_Texto = Properties.Resources.PlantillaMR.ToString();
            }
            else if (tipoReporte == "productosMasVendidos")
            {
                nombreArchivo = "ReporteProductosMasVendidos";
                PaginaHTML_Texto = Properties.Resources.PlantillaPMV.ToString();
            }
            else if (tipoReporte == "todasVentas")
            {
                nombreArchivo = "ReporteTodasVentas";
                PaginaHTML_Texto = Properties.Resources.PlantillaTV.ToString();
            }
            else if (tipoReporte == "todasVentasVendedor")
            {
                nombreArchivo = "ReporteTodasVentasVendedor";
                PaginaHTML_Texto = Properties.Resources.PlantillaRE.ToString();
            }
            else
            {
                MessageBox.Show("Tipo de reporte desconocido.");
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog
            {
                FileName = string.Format("{0}_{1}.pdf", nombreArchivo, DateTime.Now.ToString("ddMMyyyyHHmmss"))
            };

            StringBuilder filas = new StringBuilder();

            // Generar contenido según el tipo de reporte
            if (tipoReporte == "mayorRecaudacion")
            {
                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    string empleado = row.Cells["Empleado"].Value?.ToString();
                    string ventasRealizadas = row.Cells["VentasRealizadas"].Value?.ToString();
                    string totalRecaudado = row.Cells["TotalRecaudado"].Value != null ? $"${Convert.ToDecimal(row.Cells["TotalRecaudado"].Value):N2}" : string.Empty;

                    filas.Append($"<tr><td>{empleado}</td><td>{ventasRealizadas}</td><td>{totalRecaudado}</td></tr>");
                }


                if (filas.Length == 0)
                    filas.Append("<tr><td colspan='3' style='padding: 5px;'>No hay datos disponibles</td></tr>");

                // Reemplazar en la plantilla
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas.ToString());
            }
            else if (tipoReporte == "productosMasVendidos")
            {
                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    string producto = row.Cells["Producto"].Value?.ToString();
                    string cantidadVendida = row.Cells["CantidadVendida"].Value?.ToString();
                    string precioCosto = row.Cells["PrecioCosto"].Value != null ? $"${Convert.ToDecimal(row.Cells["PrecioCosto"].Value):N2}" : string.Empty;
                    string costoTotal = row.Cells["CostoTotal"].Value != null ? $"${Convert.ToDecimal(row.Cells["CostoTotal"].Value):N2}" : string.Empty;
                    string precioVenta = row.Cells["PrecioVenta"].Value != null ? $"${Convert.ToDecimal(row.Cells["PrecioVenta"].Value):N2}" : string.Empty;
                    string recaudacionTotal = row.Cells["RecaudacionTotal"].Value != null ? $"${Convert.ToDecimal(row.Cells["RecaudacionTotal"].Value):N2}" : string.Empty;

                    filas.Append($"<tr><td>{producto}</td><td>{cantidadVendida}</td><td>{precioCosto}</td><td>{costoTotal}</td><td>{precioVenta}</td><td>{recaudacionTotal}</td></tr>");
                }

                if (filas.Length == 0)
                    filas.Append("<tr><td colspan='6' style='padding: 5px;'>No hay datos disponibles</td></tr>");

                // Reemplazar en la plantilla
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas.ToString());
            }
            else if (tipoReporte == "todasVentas")
            {
                decimal totalGeneral = 0;

                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    string fechaVenta = row.Cells["FechaVenta"].Value?.ToString();
                    string cliente = row.Cells["Cliente"].Value?.ToString();
                    string vendedor = row.Cells["Vendedor"].Value?.ToString();
                    string producto = row.Cells["Producto"].Value?.ToString();
                    string precioUnitario = row.Cells["PrecioUnitario"].Value != null ? $"${Convert.ToDecimal(row.Cells["PrecioUnitario"].Value):N2}" : string.Empty;
                    string cantidad = row.Cells["Cantidad"].Value?.ToString();
                    string subtotal = row.Cells["Subtotal"].Value != null ? $"${Convert.ToDecimal(row.Cells["Subtotal"].Value):N2}" : string.Empty;
                    string totalVenta = row.Cells["TotalVenta"].Value != null ? $"${Convert.ToDecimal(row.Cells["TotalVenta"].Value):N2}" : string.Empty;

                    if (!string.IsNullOrEmpty(subtotal))
                    {
                        totalGeneral += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    }

                    filas.Append($"<tr><td>{fechaVenta}</td><td>{cliente}</td><td>{vendedor}</td><td>{producto}</td><td>{precioUnitario}</td><td>{cantidad}</td><td>{subtotal}</td><td>{totalVenta}</td></tr>");
                }

                if (filas.Length == 0)
                    filas.Append("<tr><td colspan='8' style='padding: 5px;'>No hay datos disponibles</td></tr>");

                // Reemplazar en la plantilla
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_GENERAL", totalGeneral.ToString("$#,##0.00"));
            }
            else if (tipoReporte == "todasVentasVendedor")
            {
                string EmpleadoNombre = TEmpleadoNombre.Text;
                decimal totalGeneral = 0;

                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    string fechaVenta = row.Cells["FechaVenta"].Value?.ToString();
                    string cliente = row.Cells["Cliente"].Value?.ToString();
                    string producto = row.Cells["Producto"].Value?.ToString();
                    string precioUnitario = row.Cells["PrecioUnitario"].Value != null ? $"${Convert.ToDecimal(row.Cells["PrecioUnitario"].Value):N2}" : string.Empty;
                    string cantidad = row.Cells["Cantidad"].Value?.ToString();
                    string subtotal = row.Cells["Subtotal"].Value != null ? $"${Convert.ToDecimal(row.Cells["Subtotal"].Value):N2}" : string.Empty;
                    string totalVenta = row.Cells["TotalVenta"].Value != null ? $"${Convert.ToDecimal(row.Cells["TotalVenta"].Value):N2}" : string.Empty;

                    if (!string.IsNullOrEmpty(subtotal))
                    {
                        totalGeneral += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    }

                    filas.Append($"<tr><td>{fechaVenta}</td><td>{cliente}</td><td>{producto}</td><td>{precioUnitario}</td><td>{cantidad}</td><td>{subtotal}</td><td>{totalVenta}</td></tr>");
                }

                if (filas.Length == 0)
                    filas.Append("<tr><td colspan='8' style='padding: 5px;'>No hay datos disponibles</td></tr>");

                // Reemplazar en la plantilla
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_GENERAL", totalGeneral.ToString("$#,##0.00"));
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VENDEDOR", EmpleadoNombre); 
            }

            // Agregar la fecha en la plantilla
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

                MessageBox.Show("PDF generado correctamente.");
            }
        }


    }
}
