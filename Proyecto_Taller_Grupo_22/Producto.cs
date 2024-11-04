using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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

        private void Producto_Load(object sender, EventArgs e)
        {
            CargarProductos("N");
            CargarCategorias();
        }

        private void CargarProductos(string eliminado)
        {
            try
            {
                string query = @"SELECT p.id_producto, p.nombre_producto, p.precio_venta, p.precio_costo, p.stock, c.descripcion AS categoria
                         FROM Producto p
                         INNER JOIN Categoria c ON p.id_categoria = c.id_categoria
                         WHERE p.eliminado = @eliminado";

                using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
                {
                    // Usamos SqlDataAdapter para ejecutar la consulta y llenar el DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conexion);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@eliminado", eliminado);
                    DataTable dataTable = new DataTable();

                    // Llenamos el DataTable con los datos
                    dataAdapter.Fill(dataTable);

                    // Asignamos el DataTable al DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Configurar los encabezados y anchos de columna
                    dataGridView1.Columns["id_producto"].HeaderText = "ID";
                    dataGridView1.Columns["nombre_producto"].HeaderText = "Nombre";
                    dataGridView1.Columns["precio_venta"].HeaderText = "Precio Venta";
                    dataGridView1.Columns["precio_costo"].HeaderText = "Precio Costo";
                    dataGridView1.Columns["stock"].HeaderText = "Stock";
                    dataGridView1.Columns["categoria"].HeaderText = "Categoría";

                    dataGridView1.Columns["id_producto"].Width = 80;
                    dataGridView1.Columns["nombre_producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["precio_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["precio_costo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarTodosLosProductos()
        {
            try
            {
                string query = @"SELECT p.id_producto, p.nombre_producto, p.precio_venta, p.precio_costo, p.stock, c.descripcion AS categoria
                         FROM Producto p
                         INNER JOIN Categoria c ON p.id_categoria = c.id_categoria";

                using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conexion);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    // Configurar los encabezados y anchos de columna
                    dataGridView1.Columns["id_producto"].HeaderText = "ID";
                    dataGridView1.Columns["nombre_producto"].HeaderText = "Nombre";
                    dataGridView1.Columns["precio_venta"].HeaderText = "Precio Venta";
                    dataGridView1.Columns["precio_costo"].HeaderText = "Precio Costo";
                    dataGridView1.Columns["stock"].HeaderText = "Stock";
                    dataGridView1.Columns["categoria"].HeaderText = "Categoría";

                    dataGridView1.Columns["id_producto"].Width = 80;
                    dataGridView1.Columns["nombre_producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["precio_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["precio_costo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void BTodos_Click(object sender, EventArgs e)
        {
            CargarTodosLosProductos(); 
        }
        private void BDisponibles_Click(object sender, EventArgs e)
        {
            CargarProductos("N"); 
        }
        private void BEliminados_Click(object sender, EventArgs e)
        {
            CargarProductos("S"); 
        }

        private void CargarCategorias()
        {
            CBCategoria.DisplayMember = "descripcion";  
            CBCategoria.ValueMember = "id_categoria";        

            string query = "SELECT id_categoria, descripcion FROM Categoria";
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Agregar fila "placeholder"
                DataRow row = dt.NewRow();
                row["id_categoria"] = -1;  
                row["descripcion"] = "Seleccionar categoría";  
                dt.Rows.InsertAt(row, 0);

                CBCategoria.DataSource = dt;  
            }
        }

        private bool ValidarDatosFormulario()
        {
            // Obtener los valores de los TextBox
            string nombre_producto = TNombreP.Text;
            string stock = TStock.Text;
            string precio_costo = TPCosto.Text;
            string precio_venta = TPVenta.Text;
            int idCategoria = Convert.ToInt32(CBCategoria.SelectedValue);

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre_producto) ||
                string.IsNullOrWhiteSpace(stock) ||
                string.IsNullOrWhiteSpace(precio_costo) ||
                string.IsNullOrWhiteSpace(precio_venta))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar que el tipo de categoría (ID) sea un valor entero positivo
            var selectedValue = CBCategoria.SelectedValue?.ToString();
            if (selectedValue == "-1")
            {
                MessageBox.Show("Selecciona una Categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el formato del precio
            float precioC;
            float precioV;

            if (!float.TryParse(precio_costo, out precioC) || !float.TryParse(precio_venta, out precioV) || precioC < 0 || precioV < 0)
            {
                MessageBox.Show("El Precio debe ser mayor a 0.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int stockP;
            if (!int.TryParse(stock, out stockP) || stockP < 0)
            {
                MessageBox.Show("El Stock debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosFormulario())
            {
                return; // Detener el proceso si los datos no son válidos
            }

            // Obtener los valores de los TextBox
            string nombre_producto = TNombreP.Text;
            int stock = int.Parse(TStock.Text);
            //float precio_costo = float.Parse(TPCosto.Text);
            //float precio_venta = float.Parse(TPVenta.Text);
            decimal precio_costo = Convert.ToDecimal(TPCosto.Text);
            decimal precio_venta = Convert.ToDecimal(TPVenta.Text);
            int idCategoria = Convert.ToInt32(CBCategoria.SelectedValue);

            // Llamar a la función de guardar (insertar) datos
            bool exito = GuardarDatosEnBaseDeDatos(null, nombre_producto, stock, precio_costo, precio_venta, idCategoria);

            if (exito)
            {
                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarProductos("N");
            }
        }

        private void LimpiarCampos()
        {
            TNombreP.Clear();
            TStock.Clear();
            TPCosto.Clear();
            TPVenta.Clear();

            CargarCategorias();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty; 
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar que haya filas seleccionadas
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Deshabilitar el botón "Agregar" cuando se selecciona una fila
                BAgregar.Enabled = false;

                // Habilitar el botón "Aceptar" para permitir cambios
                BAceptar.Enabled = true;

                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Copiar los datos de las celdas a los TextBox
                TNombreP.Text = row.Cells["nombre_producto"].Value.ToString();
                TStock.Text = row.Cells["stock"].Value.ToString();
                TPCosto.Text = row.Cells["precio_costo"].Value.ToString();
                TPVenta.Text = row.Cells["precio_venta"].Value.ToString();

                // Obtener el id_categoria usando la descripcion
                string descripcionCategoria = row.Cells["Categoria"].Value.ToString();
                int idCategoria = ObtenerIdCategoriaPorDescripcion(descripcionCategoria); 

                if (idCategoria != -1)
                {
                    CBCategoria.SelectedValue = idCategoria; // Establecer el valor en el ComboBox
                }
                else
                {
                    MessageBox.Show("No se encontró el id_categoria correspondiente a la descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Habilitar el botón "Agregar" cuando no haya filas seleccionadas
                BAgregar.Enabled = true;

                // Deshabilitar el botón "Aceptar" si no hay fila seleccionada
                BAceptar.Enabled = false;

                LimpiarCampos();
            }
        }

        private int ObtenerIdCategoriaPorDescripcion(string descripcion)
        {
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                conexion.Open();
                string query = "SELECT id_categoria FROM Categoria WHERE descripcion = @descripcion";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return (int)result;
                    }
                    else
                    {
                        return -1; 
                    }
                }
            }
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que haya una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no hay filas seleccionadas
            }

            // Validar los datos del formulario y pasar el email y dni actuales
            if (!ValidarDatosFormulario())
            {
                return; // Salir si hay un error de validación
            }

            // Obtener la fila seleccionada
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["id_producto"].Value;

            // Recoger los valores de los TextBox
            string nombre_producto = TNombreP.Text;
            int stock = int.Parse(TStock.Text);
            //float precio_costo = float.Parse(TPCosto.Text);
            //float precio_venta = float.Parse(TPVenta.Text);
            decimal precio_costo = Convert.ToDecimal(TPCosto.Text);
            decimal precio_venta = Convert.ToDecimal(TPVenta.Text);
            int idCategoria = Convert.ToInt32(CBCategoria.SelectedValue);

            // Actualizar los datos en la base de datos
            bool success = GuardarDatosEnBaseDeDatos(id, nombre_producto, stock, precio_costo, precio_venta, idCategoria);

            // Mostrar mensaje según el resultado
            if (success)
            {
                MessageBox.Show("Los datos han sido actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos("N"); // Refrescar el DataGridView para ver los cambios
                LimpiarCampos(); // Limpiar los campos después de la actualización
            }
        }

        private bool GuardarDatosEnBaseDeDatos(int? idProducto, string nombre_producto, int stock, decimal precio_costo, decimal precio_venta, int idCategoria)
        {
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                conexion.Open();
                using (SqlTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Validar si el producto ya existe en la base de datos
                        string campoDuplicado = ExisteProducto(nombre_producto, conexion, transaction, idProducto);
                        if (campoDuplicado != null)
                        {
                            MessageBox.Show($"El {campoDuplicado} ya está registrado. Por favor, utiliza otro valor.", "Error de Unicidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        if (idProducto == null)
                        {
                            string queryInsertProducto = "INSERT INTO Producto (nombre_producto, stock, precio_costo, precio_venta, id_categoria) " +
                                                         "OUTPUT INSERTED.id_producto " +
                                                         "VALUES (@nombre_producto, @stock, @precio_costo, @precio_venta, @id_categoria)";

                            using (SqlCommand cmdInsertProducto = new SqlCommand(queryInsertProducto, conexion, transaction))
                            {
                                cmdInsertProducto.Parameters.AddWithValue("@nombre_producto", nombre_producto);
                                cmdInsertProducto.Parameters.AddWithValue("@stock", stock);
                                cmdInsertProducto.Parameters.AddWithValue("@precio_costo", precio_costo);
                                cmdInsertProducto.Parameters.AddWithValue("@precio_venta", precio_venta);
                                cmdInsertProducto.Parameters.AddWithValue("@id_categoria", idCategoria);

                                idProducto = (int)cmdInsertProducto.ExecuteScalar();
                            }
                        }
                        else
                        {
                            // Actualizar Producto
                            string queryUpdateProducto = "UPDATE Producto SET nombre_producto = @nombre_producto, stock = @stock, precio_costo = @precio_costo, precio_venta = @precio_venta, id_categoria = @id_categoria WHERE id_producto = @id_producto";

                            using (SqlCommand cmdUpdateProducto = new SqlCommand(queryUpdateProducto, conexion, transaction))
                            {
                                cmdUpdateProducto.Parameters.AddWithValue("@id_producto", idProducto);
                                cmdUpdateProducto.Parameters.AddWithValue("@nombre_producto", nombre_producto);
                                cmdUpdateProducto.Parameters.AddWithValue("@stock", stock);
                                cmdUpdateProducto.Parameters.AddWithValue("@precio_costo", precio_costo);
                                cmdUpdateProducto.Parameters.AddWithValue("@precio_venta", precio_venta);
                                cmdUpdateProducto.Parameters.AddWithValue("@id_categoria", idCategoria);
                                
                                cmdUpdateProducto.ExecuteNonQuery();
                            }
                        }

                        // Si todo fue bien, hacer commit
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex) // Manejo de errores generales
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        private string ExisteProducto(string nombre_producto, SqlConnection conexion, SqlTransaction transaction, int? idProducto = null)
        {
            string queryNombre = "SELECT COUNT(*) FROM Producto WHERE nombre_producto = @nombre_producto" + (idProducto.HasValue ? " AND id_producto <> @id_producto" : "");
            using (SqlCommand cmdNombre = new SqlCommand(queryNombre, conexion, transaction))
            {
                cmdNombre.Parameters.AddWithValue("@nombre_producto", nombre_producto);
                if (idProducto.HasValue)
                    cmdNombre.Parameters.AddWithValue("@id_producto", idProducto.Value);

                int NombreCount = (int)cmdNombre.ExecuteScalar();
                if (NombreCount > 0) return "nombre_producto";
            }

            // Si no hay duplicados
            return null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si el clic fue en la columna del botón
                if (e.ColumnIndex == dataGridView1.Columns["btnChangeStatus"].Index && e.RowIndex >= 0)
                {
                    // Verifica que el ID no sea nulo antes de intentar convertir
                    if (dataGridView1.Rows[e.RowIndex].Cells["id_producto"].Value != DBNull.Value)
                    {
                        // Obtén el ID de la producto desde la fila seleccionada
                        int idProducto = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_producto"].Value);

                        // Variable para almacenar el estado actual
                        string estadoActual = "";

                        // Conectar a la base de datos para verificar el estado actual
                        using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
                        {
                            conexion.Open();
                            // Consulta para obtener el estado actual desde la base de datos
                            string queryEstado = "SELECT eliminado FROM Producto WHERE id_producto = @idProducto";
                            using (SqlCommand comando = new SqlCommand(queryEstado, conexion))
                            {
                                comando.Parameters.AddWithValue("@idProducto", idProducto);
                                SqlDataReader reader = comando.ExecuteReader();
                                if (reader.Read())
                                {
                                    estadoActual = reader["eliminado"].ToString();
                                }
                            }
                        }

                        string nuevoEstado = estadoActual == "N" ? "S" : "N";

                        // Actualiza el estado en la base de datos
                        UpdateStatusInDatabase(idProducto, nuevoEstado);
                    }
                    else
                    {
                        MessageBox.Show("Esta fila está vacía.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra el error en caso de que ocurra una excepción
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void UpdateStatusInDatabase(int idProducto, string nuevoEstado)
        {
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                conexion.Open();
                using (SqlTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        string query = "UPDATE Producto SET eliminado = @eliminado WHERE id_producto = @id_producto";

                        using (SqlCommand cmdUpdateProducto = new SqlCommand(query, conexion, transaction))
                        {

                            cmdUpdateProducto.Parameters.AddWithValue("@id_producto", idProducto);
                            cmdUpdateProducto.Parameters.AddWithValue("@eliminado", nuevoEstado);
                            cmdUpdateProducto.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("El estado ha sido actualizado correctamente.");
                        CargarProductos("N");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el estado: " + ex.Message);
                    }
                }
            }
        }
    }
}