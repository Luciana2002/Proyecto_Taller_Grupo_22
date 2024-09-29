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
    public partial class BuscarProductoForm : Form
    {
        // Variables para almacenar los datos seleccionados
        public string IdProductoSeleccionado { get; private set; }
        public string NombreProductoSeleccionado { get; private set; }

        public string StockProductoSeleccionado { get; private set; }

        public string PrecioProductoSeleccionado { get; private set; }

        public BuscarProductoForm()
        {
            InitializeComponent();
        }

        private void CargarProductos()
        {
            using (SqlConnection conexion = new SqlConnection("server=LUCIANA\\SQLEXPRESS; database=taller_db_1; integrated security=true"))
            {
                string query = "SELECT p.id_producto, p.nombre_producto, p.precio_venta, p.precio_costo, p.eliminado, p.stock, c.descripcion AS categoria " +
                    "FROM Producto p " +
                    "JOIN Categoria c ON p.id_categoria = c.id_categoria " +
                    "WHERE p.eliminado = 'N' AND p.stock > 0";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            string filtro = TBuscarProducto.Text;

            // Verificar si hay algún filtro ingresado
            if (string.IsNullOrWhiteSpace(filtro))
            {
                MessageBox.Show("Por favor, ingrese un criterio de búsqueda.");
                return;
            }

            // Obtener la columna seleccionada en el ComboBox
            string columnaSeleccionada = CBFiltro.SelectedItem.ToString();

            // Verificar si hay una columna seleccionada
            if (string.IsNullOrEmpty(columnaSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione un campo de búsqueda.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection("server=LUCIANA\\SQLEXPRESS; database=taller_db_1; integrated security=true"))
            {
                // Definir la consulta
                string query;

                if (columnaSeleccionada == "categoria")
                {
                    // Filtrar usando la tabla Categoria
                    query = $@"SELECT p.id_producto, p.nombre_producto, p.precio_venta, p.precio_costo, p.eliminado, p.stock, c.descripcion AS categoria
                        FROM Producto p 
                        JOIN Categoria c ON p.id_categoria = c.id_categoria 
                        WHERE c.descripcion COLLATE Latin1_General_CI_AI LIKE @filtro AND p.eliminado = 'N' AND p.stock > 0";
                }
                else
                {
                    // Filtrar usando la tabla Producto
                    query = $@"SELECT p.id_producto, p.nombre_producto, p.precio_venta, p.precio_costo, p.eliminado, p.stock, c.descripcion AS categoria
                        FROM Producto p 
                        JOIN Categoria c ON p.id_categoria = c.id_categoria 
                        WHERE p.{columnaSeleccionada} COLLATE Latin1_General_CI_AI LIKE @filtro AND p.eliminado = 'N' AND p.stock > 0";
                }

                // Crear un adaptador de datos para ejecutar la consulta
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);

                // Agregar el parámetro del filtro con wildcard para buscar coincidencias parciales
                da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                // Crear una tabla de datos para almacenar los resultados
                DataTable dt = new DataTable();

                // Llenar la tabla de datos con los resultados
                da.Fill(dt);

                // Asignar los resultados al DataGridView
                dataGridView1.DataSource = dt;

                // Verificar si se encontraron resultados
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos que coincidan con el criterio de búsqueda.");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener los datos de la fila seleccionada
            IdProductoSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["id_producto"].Value.ToString();
            NombreProductoSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["nombre_producto"].Value.ToString();
            StockProductoSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["stock"].Value.ToString();
            PrecioProductoSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["precio_venta"].Value.ToString();

            // Cerrar el formulario de búsqueda y regresar al formulario de ventas
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BuscarProductoForm_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con los nombres de las columnas de la tabla Producto
            CBFiltro.Items.Add("id_producto");
            CBFiltro.Items.Add("nombre_producto");
            CBFiltro.Items.Add("precio_venta");
            CBFiltro.Items.Add("precio_costo");
            CBFiltro.Items.Add("eliminado");
            CBFiltro.Items.Add("stock");
            CBFiltro.Items.Add("categoria");

            // Seleccionar por defecto una opción
            CBFiltro.SelectedIndex = 0; // Selecciona el primer elemento 

            // Cargar todos los productos al iniciar el formulario
            CargarProductos();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el TextBox de búsqueda y seleccionar la primera opción del ComboBox
            TBuscarProducto.Clear();
            CBFiltro.SelectedIndex = 0;

            // Cargar todos los productos sin aplicar ningún filtro
            CargarProductos();
        }
    }
}
