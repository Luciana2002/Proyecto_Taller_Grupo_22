using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace Proyecto_Taller_Grupo_22
{
    public partial class ReporteA : Form
    {
        public ReporteA()
        {
            InitializeComponent();
        }

        private string tipoReporte = "";

        private void btnReporteUsuarios_Click(object sender, EventArgs e)
        {
            tipoReporte = "usuarios";
            //dgvReporte.Rows.Clear();
            dgvReporte.Columns.Clear();

            if (dgvReporte.Columns.Count == 0)
            {
                // Configuración del DataGridView para mostrar usuarios activos e inactivos
                dgvReporte.Columns.Add("Activos", "Usuarios Activos");
                dgvReporte.Columns.Add("Inactivos", "Usuarios Inactivos");

                dgvReporte.Columns["Activos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Inactivos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT p.nombre AS Nombre, p.apellido AS Apellido, 
                    CASE WHEN p.estado = 'A' THEN 'Activo' ELSE 'Inactivo' END AS Estado
                    FROM Usuario u
                    INNER JOIN Persona p ON u.id_usuario = p.id_persona";


                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Listas para almacenar los usuarios activos e inactivos
                List<string> usuariosActivos = new List<string>();
                List<string> usuariosInactivos = new List<string>();

                while (reader.Read())
                {
                    string nombreCompleto = $"{reader["Nombre"]} {reader["Apellido"]}";
                    string estado = reader["Estado"].ToString();

                    if (estado == "Activo")
                        usuariosActivos.Add(nombreCompleto);
                    else
                        usuariosInactivos.Add(nombreCompleto);
                }

                // Determinar la cantidad de filas necesarias
                int maxRows = Math.Max(usuariosActivos.Count, usuariosInactivos.Count);

                // Llenar el DataGridView
                for (int i = 0; i < maxRows; i++)
                {
                    string activo = i < usuariosActivos.Count ? usuariosActivos[i] : string.Empty;
                    string inactivo = i < usuariosInactivos.Count ? usuariosInactivos[i] : string.Empty;
                    dgvReporte.Rows.Add(activo, inactivo);
                }

                reader.Close();
            }
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            tipoReporte = "clientes";
            //dgvReporte.Rows.Clear();
            dgvReporte.Columns.Clear();

            if (dgvReporte.Columns.Count == 0)
            {
                // Configuración del DataGridView para mostrar clientes activos e inactivos
                dgvReporte.Columns.Add("Activos", "Clientes Activos");
                dgvReporte.Columns.Add("Inactivos", "Clientes Inactivos");

                dgvReporte.Columns["Activos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Inactivos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT p.nombre AS Nombre, p.apellido AS Apellido, 
                        CASE WHEN p.estado = 'A' THEN 'Activo' ELSE 'Inactivo' END AS Estado
                        FROM Cliente c
                        INNER JOIN Persona p ON c.id_cliente = p.id_persona";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<string> clientesActivos = new List<string>();
                List<string> clientesInactivos = new List<string>();

                while (reader.Read())
                {
                    string nombreCompleto = $"{reader["Nombre"]} {reader["Apellido"]}";
                    string estado = reader["Estado"].ToString();

                    if (estado == "Activo")
                        clientesActivos.Add(nombreCompleto);
                    else
                        clientesInactivos.Add(nombreCompleto);
                }

                int maxRows = Math.Max(clientesActivos.Count, clientesInactivos.Count);

                for (int i = 0; i < maxRows; i++)
                {
                    string activo = i < clientesActivos.Count ? clientesActivos[i] : string.Empty;
                    string inactivo = i < clientesInactivos.Count ? clientesInactivos[i] : string.Empty;
                    dgvReporte.Rows.Add(activo, inactivo);
                }

                reader.Close();
            }
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            tipoReporte = "productos";
            //dgvReporte.Rows.Clear();
            dgvReporte.Columns.Clear();

            if (dgvReporte.Columns.Count == 0)
            {
                // Configuración del DataGridView para mostrar productos disponibles, sin stock y no disponibles
                dgvReporte.Columns.Add("Disponibles", "Productos Disponibles");
                dgvReporte.Columns.Add("SinStock", "Productos Sin Stock");
                dgvReporte.Columns.Add("NoDisponibles", "Productos No Disponibles");

                dgvReporte.Columns["Disponibles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["SinStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["NoDisponibles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT nombre_producto, stock, eliminado FROM Producto";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<string> productosDisponibles = new List<string>();
                List<string> productosSinStock = new List<string>();
                List<string> productosNoDisponibles = new List<string>();

                while (reader.Read())
                {
                    string nombreProducto = reader["nombre_producto"].ToString();
                    int stock = Convert.ToInt32(reader["stock"]);
                    string eliminado = reader["eliminado"].ToString();

                    if (eliminado == "N" && stock > 0)
                        productosDisponibles.Add(nombreProducto);
                    else if (eliminado == "N" && stock == 0)
                        productosSinStock.Add(nombreProducto);
                    else if (eliminado == "S")
                        productosNoDisponibles.Add(nombreProducto);
                }

                // Determinar la cantidad de filas necesarias
                int maxRows = Math.Max(productosDisponibles.Count, Math.Max(productosSinStock.Count, productosNoDisponibles.Count));

                // Llenar el DataGridView
                for (int i = 0; i < maxRows; i++)
                {
                    string disponible = i < productosDisponibles.Count ? productosDisponibles[i] : string.Empty;
                    string sinStock = i < productosSinStock.Count ? productosSinStock[i] : string.Empty;
                    string noDisponible = i < productosNoDisponibles.Count ? productosNoDisponibles[i] : string.Empty;
                    dgvReporte.Rows.Add(disponible, sinStock, noDisponible);
                }

                reader.Close();
            }
        }

        private void btnReporteBackups_Click(object sender, EventArgs e)
        {
            tipoReporte = "backups"; 
            //dgvReporte.Rows.Clear(); 
            dgvReporte.Columns.Clear();

            if (dgvReporte.Columns.Count == 0)
            {
                dgvReporte.Columns.Add("Fecha", "Fecha de Backup");
                dgvReporte.Columns.Add("Empleado", "Empleado");
                dgvReporte.Columns.Add("Ruta", "Ruta de Backup");

                dgvReporte.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Empleado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReporte.Columns["Ruta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            string connectionString = "server=.; database=taller_db_1; integrated security=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT B.fecha_backup AS Fecha, U.nombre_usuario AS Empleado, B.ruta_backup AS Ruta
                    FROM Backup_Registro B
                    INNER JOIN Usuario U ON B.id_usuario = U.id_usuario";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string fechaBackup = Convert.ToDateTime(reader["Fecha"]).ToString("g"); 
                    string empleado = reader["Empleado"].ToString();
                    string ruta = reader["Ruta"].ToString();

                    dgvReporte.Rows.Add(fechaBackup, empleado, ruta);
                }

                reader.Close();
            }
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            // Establecer el nombre del archivo y seleccionar la plantilla según el tipo de reporte
            string nombreArchivo;
            string PaginaHTML_Texto;

            if (tipoReporte == "usuarios")
            {
                nombreArchivo = "ReporteUsuarios";
                PaginaHTML_Texto = Properties.Resources.PlantillaAU.ToString();
            }
            else if (tipoReporte == "clientes")
            {
                nombreArchivo = "ReporteClientes";
                PaginaHTML_Texto = Properties.Resources.PlantillaAC.ToString();
            }
            else if (tipoReporte == "productos")
            {
                nombreArchivo = "ReporteProductos";
                PaginaHTML_Texto = Properties.Resources.PlantillaAP.ToString();
            }
            else if (tipoReporte == "backups")
            {
                nombreArchivo = "ReporteBackups";
                PaginaHTML_Texto = Properties.Resources.PlantillaAB.ToString();
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

            StringBuilder filasActivos = new StringBuilder();
            StringBuilder filasInactivos = new StringBuilder();
            int totalActivos = 0;
            int totalInactivos = 0;

            StringBuilder filasDisponibles = new StringBuilder();
            StringBuilder filasSinStock = new StringBuilder();
            StringBuilder filasNoDisponibles = new StringBuilder();
            int totalDisponibles = 0;
            int totalSinStock = 0;
            int totalNoDisponibles = 0;

            StringBuilder filasBackups = new StringBuilder();
            int totalBackups = -1;

            // Generar contenido según el tipo de reporte

            if (tipoReporte == "backups")
            {
                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    string fecha = row.Cells["Fecha"].Value?.ToString();
                    string empleado = row.Cells["Empleado"].Value?.ToString();
                    string ruta = row.Cells["Ruta"].Value?.ToString();

                    filasBackups.Append($"<tr><td>{fecha}</td><td>{empleado}</td><td>{ruta}</td></tr>");
                    totalBackups++;
                }

                if (filasBackups.Length == 0) filasBackups.Append("<tr><td style='padding: 5px;'>No existen Backups</td></tr>");

                // Reemplazar las etiquetas en la plantilla de backups
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filasBackups.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_BACKUPS", totalBackups.ToString());
            }
            else if (tipoReporte == "productos")
            {
                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    if (row.Cells["Disponibles"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Disponibles"].Value.ToString()))
                    {
                        filasDisponibles.Append($"<tr><td style='padding: 5px;'>{row.Cells["Disponibles"].Value}</td></tr>");
                        totalDisponibles++;
                    }

                    if (row.Cells["SinStock"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["SinStock"].Value.ToString()))
                    {
                        filasSinStock.Append($"<tr><td style='padding: 5px;'>{row.Cells["SinStock"].Value}</td></tr>");
                        totalSinStock++;
                    }

                    if (row.Cells["NoDisponibles"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["NoDisponibles"].Value.ToString()))
                    {
                        filasNoDisponibles.Append($"<tr><td style='padding: 5px;'>{row.Cells["NoDisponibles"].Value}</td></tr>");
                        totalNoDisponibles++;
                    }
                }

                if (filasDisponibles.Length == 0) filasDisponibles.Append("<tr><td style='padding: 5px;'>No hay productos disponibles</td></tr>");
                if (filasSinStock.Length == 0) filasSinStock.Append("<tr><td style='padding: 5px;'>No hay productos sin stock</td></tr>");
                if (filasNoDisponibles.Length == 0) filasNoDisponibles.Append("<tr><td style='padding: 5px;'>No hay productos no disponibles</td></tr>");

                // Reemplazar en la plantilla los datos de productos
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS_DISPONIBLES", filasDisponibles.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS_SINSTOCK", filasSinStock.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS_NODISPONIBLES", filasNoDisponibles.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_DISPONIBLES", totalDisponibles.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_SINSTOCK", totalSinStock.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_NODISPONIBLES", totalNoDisponibles.ToString());
            }
            else
            {
                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    if (row.Cells["Activos"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Activos"].Value.ToString()))
                    {
                        filasActivos.Append($"<tr><td style='padding: 5px;'>{row.Cells["Activos"].Value}</td></tr>");
                        totalActivos++;
                    }

                    if (row.Cells["Inactivos"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Inactivos"].Value.ToString()))
                    {
                        filasInactivos.Append($"<tr><td style='padding: 5px;'>{row.Cells["Inactivos"].Value}</td></tr>");
                        totalInactivos++;
                    }
                }

                if (filasActivos.Length == 0) filasActivos.Append("<tr><td style='padding: 5px;'>No hay usuarios activos</td></tr>");
                if (filasInactivos.Length == 0) filasInactivos.Append("<tr><td style='padding: 5px;'>No hay usuarios inactivos</td></tr>");

                // Reemplazar en la plantilla los datos generados para usuarios o clientes
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS_ACTIVOS", filasActivos.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS_INACTIVOS", filasInactivos.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_ACTIVOS", totalActivos.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL_INACTIVOS", totalInactivos.ToString());
            }

            // Agregar la fecha en la plantilla
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