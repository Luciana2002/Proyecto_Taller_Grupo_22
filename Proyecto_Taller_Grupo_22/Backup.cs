using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Taller_Grupo_22
{
    public partial class Backup : Form
    {
        private const string NombreBaseDatos = "taller_db_1";
        private const string ConnectionString = "Server=.;Database=" + NombreBaseDatos + ";Integrated Security=True;";

        public Backup()
        {
            InitializeComponent();
            this.Load += Backup_Load;
        }

        // Evento de carga del formulario
        private void Backup_Load(object sender, EventArgs e)
        {
            txtBaseDatos.Text = NombreBaseDatos;
            txtBaseDatos.ReadOnly = true; // Hacer el TextBox de solo lectura
        }

        // Función para mostrar un mensaje y detener la ejecución si el valor es inválido
        private bool ValidarRuta(string ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta))
            {
                MessageBox.Show("Por favor, seleccione una ruta válida.");
                return false;
            }
            return true;
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

        // Función para realizar el backup de la base de datos
        private void RealizarBackup(string rutaBackup)
        {
            string rutaCompleta = System.IO.Path.Combine(rutaBackup, $"{NombreBaseDatos}.bak");
            string query = $"BACKUP DATABASE [{NombreBaseDatos}] TO DISK = '{rutaCompleta.Replace("'", "''")}'";

            EjecutarConsulta(query, "Backup realizado con éxito!");
        }

        // Función para conectar a la base de datos y ejecutar una consulta
        private void EjecutarConsulta(string query, string mensajeExito)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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
            EjecutarConsulta("SELECT 1", "Conexión exitosa!"); // Verificación simple de conexión
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            SeleccionarRutaGuardado();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string rutaBackup = txtRutaGuardar.Text;

            if (ValidarRuta(rutaBackup))
            {
                RealizarBackup(rutaBackup);
            }
        }
    }
}
