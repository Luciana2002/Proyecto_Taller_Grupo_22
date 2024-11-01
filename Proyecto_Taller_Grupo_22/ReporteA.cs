using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class ReporteA : Form
    {
        public ReporteA()
        {
            InitializeComponent();
        }

        private void btnReporteUsuarios_Click(object sender, EventArgs e)
        {
            GenerarReporteUsuarios();
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            GenerarReporteClientes();
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            GenerarReporteProductos();
        }

        private void btnReporteBackups_Click(object sender, EventArgs e)
        {
            GenerarReporteBackups();
        }

        private void GenerarReporteUsuarios()
        {
            dgvReporte.Rows.Clear();
            string query = @"
                SELECT CONCAT(p.nombre, ' ', p.apellido) AS NombreCompleto,
                       COUNT(CASE WHEN p.estado = 'A' THEN 1 END) AS Activos,
                       COUNT(CASE WHEN p.estado = 'I' THEN 1 END) AS Inactivos
                FROM Usuario u
                INNER JOIN Persona p ON u.id_usuario = p.id_persona
                GROUP BY p.nombre, p.apellido";

            EjecutarConsultaYMostrar(query, new[] { "NombreCompleto", "Activos", "Inactivos" }, "Reporte de Usuarios Activos e Inactivos");
        }

        private void GenerarReporteClientes()
        {
            dgvReporte.Rows.Clear();
            string query = @"
                SELECT CONCAT(p.nombre, ' ', p.apellido) AS NombreCompleto,
                       COUNT(CASE WHEN p.estado = 'A' THEN 1 END) AS Activos,
                       COUNT(CASE WHEN p.estado = 'I' THEN 1 END) AS Inactivos
                FROM Cliente c
                INNER JOIN Persona p ON c.id_cliente = p.id_persona
                GROUP BY p.nombre, p.apellido";

            EjecutarConsultaYMostrar(query, new[] { "NombreCompleto", "Activos", "Inactivos" }, "Reporte de Clientes Activos e Inactivos");
        }

        private void GenerarReporteProductos()
        {
            dgvReporte.Rows.Clear();
            string query = @"
                SELECT pr.nombre_producto AS Producto,
                       COUNT(CASE WHEN pr.stock > 0 THEN 1 END) AS Disponibles,
                       COUNT(CASE WHEN pr.stock = 0 THEN 1 END) AS SinStock,
                       COUNT(CASE WHEN pr.eliminado = 'S' THEN 1 END) AS NoDisponibles
                FROM Producto pr
                GROUP BY pr.nombre_producto";

            EjecutarConsultaYMostrar(query, new[] { "Producto", "Disponibles", "SinStock", "NoDisponibles" }, "Reporte de Productos");
        }

        private void GenerarReporteBackups()
        {
            dgvReporte.Rows.Clear();
            string query = @"
                SELECT CONCAT(p.nombre, ' ', p.apellido) AS Empleado,
                       b.fecha_backup AS FechaBackup,
                       b.ruta_backup AS Ruta
                FROM Backup_Registro b
                INNER JOIN Usuario u ON b.id_usuario = u.id_usuario
                INNER JOIN Persona p ON u.id_usuario = p.id_persona";

            EjecutarConsultaYMostrar(query, new[] { "Empleado", "FechaBackup", "Ruta" }, "Reporte de Backups");
        }

        private void EjecutarConsultaYMostrar(string query, string[] columnNames, string titulo)
        {
            string connectionString = "server=LUCIANA\\SQLEXPRESS; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Configura las columnas del DataGridView para mostrar los resultados
                dgvReporte.Columns.Clear();
                foreach (string column in columnNames)
                {
                    dgvReporte.Columns.Add(column, column);
                    dgvReporte.Columns[column].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                // Añade las filas al DataGridView
                while (reader.Read())
                {
                    object[] rowData = new object[columnNames.Length];
                    for (int i = 0; i < columnNames.Length; i++)
                    {
                        rowData[i] = reader[columnNames[i]];
                    }
                    dgvReporte.Rows.Add(rowData);
                }
                reader.Close();
            }
            GenerarPDF(titulo);
        }

        private void GenerarPDF(string titulo)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"{titulo}_{DateTime.Now:ddMMyyyyHHmmss}.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Paragraph(titulo, new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD)));

                    PdfPTable table = new PdfPTable(dgvReporte.Columns.Count);
                    table.WidthPercentage = 100;

                    // Añadir encabezados
                    foreach (DataGridViewColumn column in dgvReporte.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText));
                    }

                    // Añadir filas
                    foreach (DataGridViewRow row in dgvReporte.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("Reporte PDF generado correctamente.");
            }
        }
    }
}
