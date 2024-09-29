using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Taller_Grupo_22
{
    public partial class Form1 : Form
    {

        // Obtener la cadena de conexi�n desde el archivo App.config
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            string usuario = TUsuario.Text;
            string contrasena = TContrasena.Text;

            if (VerificarUsuario(usuario, contrasena))
            {
                CargarInformacionUsuario(usuario); // Carga la informaci�n del usuario

                //MessageBox.Show("Login exitoso!");
                //  abrir el formulario principal o p�gina principal de tu aplicaci�n.
                this.Hide(); // Para ocultar el formulario de login actual.
                var formPrincipal = new formPrincipal();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos.");
            }

        }


        // M�todo que verifica si el usuario existe en la base de datos
        //private bool VerificarUsuario(string usuario, string contrasena)
        //{
        // string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        // using (SqlConnection conexion = new SqlConnection("server=LUCIANA\\SQLEXPRESS; database=taller_db_1; integrated security=true"))
        //{
        //  try
        //{
        //  conexion.Open();
        //string query = "SELECT COUNT(1) FROM Usuario WHERE nombre_usuario = @nombre_usuario AND contrase�a = @contrase�a";
        //  SqlCommand cmd = new SqlCommand(query, conexion);
        //  cmd.Parameters.AddWithValue("@nombre_usuario", usuario);
        //  cmd.Parameters.AddWithValue("@contrase�a", contrasena);

        //  int count = Convert.ToInt32(cmd.ExecuteScalar());

        //   return count == 1;
        //  }
        //catch (Exception ex)
        //  {
        //    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
        //  return false;
        //   }
        //   }
        // }

        private bool VerificarUsuario(string usuario, string contrasena)
        {
            using (SqlConnection conexion = new SqlConnection("server=LUCIANA\\SQLEXPRESS; database=taller_db_1; integrated security=true"))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT COUNT(1) FROM Usuario WHERE nombre_usuario = @nombre_usuario AND contrase�a = @contrase�a";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    // Par�metro para nombre de usuario
                    cmd.Parameters.Add(new SqlParameter("@nombre_usuario", System.Data.SqlDbType.VarChar, 50));
                    cmd.Parameters["@nombre_usuario"].Value = usuario;

                    // Par�metro para contrase�a
                    cmd.Parameters.Add(new SqlParameter("@contrase�a", System.Data.SqlDbType.VarChar, 50));
                    cmd.Parameters["@contrase�a"].Value = contrasena;

                    // Ejecutar la consulta
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                    return false;
                }
            }
        }

        private void CargarInformacionUsuario(string nombreUsuario)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
            u.id_usuario, 

                p.nombre,
                p.apellido,
                p.sexo,
                p.email,
                p.dni,
                p.telefono,
                p.cumplea�os,
                pr.descripcion AS perfil
            FROM 
                Usuario u
            JOIN 
                Persona p ON u.id_usuario = p.id_persona
            JOIN 
                 Perfil pr ON u.id_perfil = pr.id_perfil
            
            WHERE 
                u.nombre_usuario = @nombre_usuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Asignar los valores a la clase est�tica
                        UsuarioInfo.SetNombreUsuario(nombreUsuario);
                        UsuarioInfo.IDUsuario = Convert.ToInt32(reader["id_usuario"]);  // ID del usuario

                        UsuarioInfo.Nombre = reader["nombre"].ToString();
                        UsuarioInfo.Apellido = reader["apellido"].ToString();
                        UsuarioInfo.Sexo = reader["sexo"].ToString();
                        UsuarioInfo.Email = reader["email"].ToString();
                        UsuarioInfo.DNI = reader["dni"].ToString();
                        UsuarioInfo.Telefono = reader["telefono"].ToString();
                        UsuarioInfo.Cumplea�os = Convert.ToDateTime(reader["cumplea�os"]);
                        UsuarioInfo.Perfil = reader["perfil"].ToString(); // Guardamos el perfil

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la informaci�n: " + ex.Message);
                }
            }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty; // Limpiar cada TextBox
                }
            }
        }
    }



}