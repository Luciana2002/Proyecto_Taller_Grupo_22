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
    public partial class DetalleVentaForm : Form
    {
        private int idVenta;

        public DetalleVentaForm(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
        }

        private void DetalleVentaForm_Load(object sender, EventArgs e)
        {
            // Cargar los detalles de la venta
            CargarDetallesVenta();
        }

        private void CargarDetallesVenta()
        {
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                // Consulta para obtener los detalles de la venta
                string query = @"SELECT dv.cantidad, p.nombre_producto, p.precio_venta , dv.subtotal
                                 FROM Detalle_Venta dv
                                 JOIN Producto p ON dv.id_producto = p.id_producto
                                 WHERE dv.id_venta = @idVenta";

                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.SelectCommand.Parameters.AddWithValue("@idVenta", idVenta);

                // Llenar la tabla de datos con los detalles
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Asignar los resultados al DataGridView
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["cantidad"].HeaderText = "Cantidad";
                dataGridView1.Columns["nombre_producto"].HeaderText = "Nombre Producto";
                dataGridView1.Columns["precio_venta"].HeaderText = "Precio de Venta";
                dataGridView1.Columns["subtotal"].HeaderText = "Subtotal";
            }
        }
    }
}
