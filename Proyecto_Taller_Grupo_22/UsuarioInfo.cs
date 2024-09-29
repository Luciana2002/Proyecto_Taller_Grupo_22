using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_Grupo_22
{
    // UsuarioInfo.cs
    public static class UsuarioInfo
    {
        public static int IDUsuario { get; set; }  // Propiedad para el ID del usuario

        public static string NombreUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Sexo { get; set; }
        public static string Email { get; set; }
        public static string DNI { get; set; }
        public static string Telefono { get; set; }
        public static DateTime Cumpleaños { get; set; }
        public static string Perfil { get; set; } // Agregar esta propiedad


        public static bool EsAdministrador { get; set; } // Variable para rol Administrador
        public static bool EsGerente { get; set; }       // Variable para rol Gerente
        public static bool EsEmpleado { get; set; }      // Variable para rol Empleado

        public static void SetNombreUsuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
    }
}