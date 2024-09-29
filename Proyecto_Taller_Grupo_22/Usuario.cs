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
using static Proyecto_Taller_Grupo_22.Form1;

namespace Proyecto_Taller_Grupo_22
{
    public partial class Usuario : Form
    {

        // private string connectionString = "tu_connection_string_aqui"; // Define tu cadena de conexión


        public Usuario()
        {
            InitializeComponent();
            CargarInformacionUsuario();
        }

        private void CargarInformacionUsuario()
        {
            TxtNombre.Text = UsuarioInfo.Nombre;
            TxtApellido.Text = UsuarioInfo.Apellido;
            TxtSexo.Text = UsuarioInfo.Sexo;
            TxtEmail.Text = UsuarioInfo.Email;
            TxtDNI.Text = UsuarioInfo.DNI;
            TxtTelefono.Text = UsuarioInfo.Telefono;
            TxtCumpleaños.Text = UsuarioInfo.Cumpleaños.ToShortDateString(); // Formatear la fecha

            // Hacer los TextBox de solo lectura
            TxtNombre.ReadOnly = true;
            TxtApellido.ReadOnly = true;
            TxtSexo.ReadOnly = true;
            TxtEmail.ReadOnly = true;
            TxtDNI.ReadOnly = true;
            TxtTelefono.ReadOnly = true;
            TxtCumpleaños.ReadOnly = true;
        }
    }
}
