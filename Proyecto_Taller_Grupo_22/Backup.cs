using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Taller_Grupo_22
{
    public partial class Backup : Form
    {
        private const string ServerConnectionString = "Server=.;Integrated Security=True;";

        public Backup()
        {
            InitializeComponent();
            this.Load += Backup_Load;
        }

        // Evento de carga del formulario
        private void Backup_Load(object sender, EventArgs e)
        {
            CargarBasesDeDatos();
        }

        // Método para cargar todas las bases de datos en el ComboBox
        private void CargarBasesDeDatos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ServerConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE state_desc = 'ONLINE' AND name NOT IN ('master', 'tempdb', 'model', 'msdb')", connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbBasesDatos.Items.Add(reader["name"].ToString());
                            }
                        }
                    }
                }
                if (cmbBasesDatos.Items.Count > 0)
                {
                    cmbBasesDatos.SelectedIndex = 0; // Seleccionar la primera base de datos por defecto
                }
                else
                {
                    MessageBox.Show("No se encontraron bases de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bases de datos: {ex.Message}");
            }
        }

        // Función para seleccionar la ruta de guardado
        private void SeleccionarRutaGuardado()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtRutaGuardar.Text = dialog.SelectedPath;
                }
            }
        }

        // Función para validar si la ruta es válida
        private bool ValidarRuta(string ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta))
            {
                MessageBox.Show("Por favor, seleccione una ruta válida.");
                return false;
            }
            return true;
        }

        // Función para realizar el backup de la base de datos seleccionada
        private void RealizarBackup(string baseDatos, string rutaBackup)
        {
            string rutaCompleta = System.IO.Path.Combine(rutaBackup, $"{baseDatos}.bak");
            string query = $"BACKUP DATABASE [{baseDatos}] TO DISK = '{rutaCompleta.Replace("'", "''")}'";

            EjecutarConsulta(baseDatos, query, "Backup realizado con éxito!");
        }

        // Función para conectar a la base de datos seleccionada y ejecutar una consulta
        private void EjecutarConsulta(string baseDatos, string query, string mensajeExito)
        {
            string connectionString = $"Server=.;Database={baseDatos};Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show(mensajeExito);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Eventos de botones
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (cmbBasesDatos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una base de datos.");
                return;
            }

            string baseDatosSeleccionada = cmbBasesDatos.SelectedItem.ToString();
            EjecutarConsulta(baseDatosSeleccionada, "SELECT 1", "Conexión exitosa!");
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            SeleccionarRutaGuardado();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (cmbBasesDatos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una base de datos.");
                return;
            }

            string rutaBackup = txtRutaGuardar.Text;
            string baseDatosSeleccionada = cmbBasesDatos.SelectedItem.ToString();

            if (ValidarRuta(rutaBackup))
            {
                RealizarBackup(baseDatosSeleccionada, rutaBackup);
            }
        }
    }
}
