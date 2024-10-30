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
using static Proyecto_Taller_Grupo_22.BuscarClienteForm;

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
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                string query = "SELECT p.id_producto, p.nombre_producto, p.precio_venta, p.stock, c.descripcion AS categoria " +
                    "FROM Producto p " +
                    "JOIN Categoria c ON p.id_categoria = c.id_categoria " +
                    "WHERE p.eliminado = 'N' AND p.stock > 0";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id_producto"].HeaderText = "ID Producto";
                dataGridView1.Columns["nombre_producto"].HeaderText = "Producto";
                dataGridView1.Columns["precio_venta"].HeaderText = "Precio Venta";
                dataGridView1.Columns["stock"].HeaderText = "Stock";
                dataGridView1.Columns["categoria"].HeaderText = "Categoría";

                dataGridView1.Columns["id_producto"].Width = 90;
                dataGridView1.Columns["nombre_producto"].Width = 294;
                dataGridView1.Columns["precio_venta"].Width = 120;
                dataGridView1.Columns["stock"].Width = 90;
                dataGridView1.Columns["categoria"].Width = 120;
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
            ComboBoxItem itemSeleccionado = (ComboBoxItem)CBFiltro.SelectedItem;
            string columnaSeleccionada = itemSeleccionado?.Value;

            // Verificar si hay una columna seleccionada
            if (string.IsNullOrEmpty(columnaSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione un campo de búsqueda.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                // Definir la consulta en función del tipo de columna seleccionada
                string query;
                if (columnaSeleccionada == "categoria" || columnaSeleccionada == "nombre_producto")
                {
                    // Usa COLLATE solo en columnas de texto
                    query = $@"
                SELECT p.id_producto, p.nombre_producto, p.precio_venta, p.stock, c.descripcion AS categoria
                FROM Producto p
                JOIN Categoria c ON p.id_categoria = c.id_categoria
                WHERE {(columnaSeleccionada == "categoria" ? "c.descripcion" : "p.nombre_producto")} COLLATE Latin1_General_CI_AI LIKE @filtro
                AND p.eliminado = 'N' AND p.stock > 0";
                }
                else
                {
                    // No usa COLLATE para columnas numéricas
                    query = $@"
                SELECT p.id_producto, p.nombre_producto, p.precio_venta, p.stock, c.descripcion AS categoria
                FROM Producto p
                JOIN Categoria c ON p.id_categoria = c.id_categoria
                WHERE p.{columnaSeleccionada} LIKE @filtro
                AND p.eliminado = 'N' AND p.stock > 0";
                }

                // Crear un adaptador de datos para ejecutar la consulta
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);

                // Agregar el parámetro del filtro con comodín para coincidencias parciales
                da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                // Crear una tabla de datos para almacenar los resultados
                DataTable dt = new DataTable();

                // Llenar la tabla de datos con los resultados
                da.Fill(dt);

                // Asignar los resultados al DataGridView
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id_producto"].HeaderText = "ID Producto";
                dataGridView1.Columns["nombre_producto"].HeaderText = "Producto";
                dataGridView1.Columns["precio_venta"].HeaderText = "Precio Venta";
                dataGridView1.Columns["stock"].HeaderText = "Stock";
                dataGridView1.Columns["categoria"].HeaderText = "Categoría";

                dataGridView1.Columns["id_producto"].Width = 90;
                dataGridView1.Columns["nombre_producto"].Width = 294;
                dataGridView1.Columns["precio_venta"].Width = 120;
                dataGridView1.Columns["stock"].Width = 90;
                dataGridView1.Columns["categoria"].Width = 120;

                // Verificar si se encontraron resultados
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos que coincidan con el criterio de búsqueda.");
                }
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en una fila válida
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; 
            }

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
            // Llenar el ComboBox con los nombres amigables para los filtros
            CBFiltro.Items.Add(new ComboBoxItem("ID Producto", "id_producto"));
            CBFiltro.Items.Add(new ComboBoxItem("Producto", "nombre_producto"));
            CBFiltro.Items.Add(new ComboBoxItem("Precio Venta", "precio_venta"));
            CBFiltro.Items.Add(new ComboBoxItem("Stock", "stock"));
            CBFiltro.Items.Add(new ComboBoxItem("Categoría", "categoria"));

            // Seleccionar por defecto una opción
            CBFiltro.SelectedIndex = 0; // Selecciona el primer elemento ("ID Producto")

            // Cargar todos los productos al iniciar el formulario
            CargarProductos();
        }

        public class ComboBoxItem
        {
            public string Display { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string display, string value)
            {
                Display = display;
                Value = value;
            }

            public override string ToString()
            {
                return Display; // Esto es lo que se mostrará en el ComboBox
            }
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
