using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Taller_Grupo_22
{
    public partial class Backup : Form
    {
        private const string NombreBaseDatos = "taller_db_1";
        private const string ConnectionString = "server=.;Database=" + NombreBaseDatos + ";Integrated Security=True;";

        public Backup()
        {
            InitializeComponent();
            this.Load += Backup_Load;
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            txtBaseDatos.Text = NombreBaseDatos;
            txtBaseDatos.ReadOnly = true;
        }

        private bool ValidarRuta(string ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta))
            {
                MessageBox.Show("Por favor, seleccione una ruta válida.");
                return false;
            }
            return true;
        }

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

        //private void SeleccionarArchivoRespaldo()
        //{
        //    using (OpenFileDialog dialog = new OpenFileDialog())
        //    {
        //        dialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
        //        if (dialog.ShowDialog() == DialogResult.OK)
        //        {
        //            txtRutaRestaurar.Text = dialog.FileName;
        //        }
        //    }
        //}

        private void RealizarBackup(string rutaBackup)
        {
            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string rutaCompleta = System.IO.Path.Combine(rutaBackup, $"{NombreBaseDatos}_{fechaActual}.bak");
            string queryBackup = $"BACKUP DATABASE [{NombreBaseDatos}] TO DISK = '{rutaCompleta.Replace("'", "''")}'";

            EjecutarConsulta(queryBackup, "Backup realizado con éxito!");
            RegistrarBackup(rutaCompleta);
        }

        private void RegistrarBackup(string rutaBackup)
        {
            int idUsuario = UsuarioInfo.IDUsuario;

            string queryRegistro = "INSERT INTO Backup_Registro (fecha_backup, id_usuario, ruta_backup) " +
                                   "VALUES (GETDATE(), @IdUsuario, @RutaBackup)";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryRegistro, connection))
                    {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        command.Parameters.AddWithValue("@RutaBackup", rutaBackup);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el backup: {ex.Message}");
            }
        }

        //private void RestaurarBackup(string rutaBackup)
        //{
            // Cambia la cadena de conexión para que se conecte a la base de datos "master"
        //    string masterConnectionString = "server=.;Database=master;Integrated Security=True;";
        //
        //    string queryRestaurar = $@"
        //        ALTER DATABASE [{NombreBaseDatos}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        //        RESTORE DATABASE [{NombreBaseDatos}] FROM DISK = '{rutaBackup.Replace("'", "''")}' WITH REPLACE;
        //        ALTER DATABASE [{NombreBaseDatos}] SET MULTI_USER;";
        //
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(masterConnectionString))
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand(queryRestaurar, connection))
        //            {
        //                command.ExecuteNonQuery();
        //                MessageBox.Show("Restauración realizada con éxito!");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error durante la restauración: {ex.Message}");
        //    }
        //}

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

        private void btnConectar_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT 1", "Conexión exitosa!");
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            SeleccionarRutaGuardado();
        }

        //private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        //{
        //    SeleccionarArchivoRespaldo();
        //}

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string rutaBackup = txtRutaGuardar.Text;

            if (ValidarRuta(rutaBackup))
            {
                RealizarBackup(rutaBackup);
            }
        }

        //private void btnRestaurar_Click(object sender, EventArgs e)
        //{
        //    string rutaRespaldo = txtRutaRestaurar.Text;
        //
        //    if (ValidarRuta(rutaRespaldo))
        //    {
        //        RestaurarBackup(rutaRespaldo);
        //    }
        //}
    }
}
