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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Método para cargar los datos de SQL Server en el DataGridView
        private void CargarDatos()
        {
            try
            {
                // Consulta SQL que deseas ejecutar
                string query = "SELECT * FROM Producto";

                // Usamos SqlConnection para conectarnos a la base de datos
                using (SqlConnection conexion = new SqlConnection("server=LUCIANA\\SQLEXPRESS; database=taller_db_1; integrated security=true"))
                {
                    // Usamos SqlDataAdapter para ejecutar la consulta y llenar el DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conexion);
                    DataTable dataTable = new DataTable();

                    // Llenamos el DataTable con los datos
                    dataAdapter.Fill(dataTable);

                    // Asignamos el DataTable al DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el ID del producto seleccionado (asumiendo que es la primera columna)
                int productoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Pregunta al usuario si está seguro de eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    // Ejecuta la eliminación en la base de datos
                    EliminarProducto(productoId);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.");
            }
        }

        // Método para eliminar un producto de la base de datos
        private void EliminarProducto(int productoId)
        {
            try
            {
                string query = "DELETE FROM Producto WHERE id_producto = @id_producto"; // Ajusta el nombre del campo ID según tu base de datos

                using (SqlConnection conexion = new SqlConnection("server=LUCIANA\\SQLEXPRESS; database=taller_db_1; integrated security=true"))
                {
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@id_producto", productoId);

                        conexion.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Recarga los datos en el DataGridView
                CargarDatos();
                MessageBox.Show("Producto eliminado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

    }
}
