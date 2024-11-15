﻿using System;
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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            TVendedorID.Text = UsuarioInfo.IDUsuario.ToString();
            TVendedorNombre.Text = UsuarioInfo.Nombre;
            CargarTiposDeVentaEnComboBox();
            
            // Llenar el ComboBox con nombres más amigables para el usuario
            CBFiltro.Items.Add("ID Venta");
            CBFiltro.Items.Add("Fecha");
            CBFiltro.Items.Add("Total Venta");
            CBFiltro.Items.Add("Método Pago");
            CBFiltro.Items.Add("Nombre Cliente");
            CBFiltro.Items.Add("Apellido Cliente");

            // Seleccionar por defecto una opción
            CBFiltro.SelectedIndex = 0; // Selecciona el primer elemento 

            // Cargar todas las ventas
            CargarDatos();
        }

        private void BBuscarC_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario de búsqueda de clientes
            BuscarClienteForm buscarCliente = new BuscarClienteForm();

            // Mostrar el formulario de búsqueda como un cuadro de diálogo
            if (buscarCliente.ShowDialog() == DialogResult.OK)
            {
                // Recuperar los datos seleccionados en el formulario de búsqueda y asignarlos a los TextBox del formulario de ventas
                TClienteID.Text = buscarCliente.IdClienteSeleccionado;
                TClienteNombre.Text = buscarCliente.NombreClienteSeleccionado;
                //txtApellidoCliente.Text = buscarCliente.ApellidoClienteSeleccionado;
            }
        }

        private void BBuscarP_Click(object sender, EventArgs e)
        {
            BuscarProductoForm buscarProducto = new BuscarProductoForm();

            if (buscarProducto.ShowDialog() == DialogResult.OK)
            {
                TProductoID.Text = buscarProducto.IdProductoSeleccionado;
                TProductoNombre.Text = buscarProducto.NombreProductoSeleccionado;
                TStock.Text = buscarProducto.StockProductoSeleccionado;
                TPrecioV.Text = buscarProducto.PrecioProductoSeleccionado;
            }
        }

        private void CargarTiposDeVentaEnComboBox()
        {
            CBTipoV.DisplayMember = "descripcion";  // Mostrar la descripción
            CBTipoV.ValueMember = "id_tipo";        // Asociar el valor con id_tipo

            string query = "SELECT id_tipo, descripcion FROM Tipo_Venta";
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                CBTipoV.DataSource = dt;  // Asociar el DataTable al ComboBox
            }
        }

        private void CalcularSubtotal(object sender, EventArgs e)
        {
            // Asegurarse de que ambos campos tengan datos válidos antes de calcular
            if (!string.IsNullOrEmpty(TPrecioV.Text) && numericUpDown1.Value > 0)
            {
                try
                {
                    // Obtener el precio y la cantidad
                    decimal precio = Convert.ToDecimal(TPrecioV.Text);
                    decimal cantidad = numericUpDown1.Value;

                    // Calcular el subtotal
                    decimal subtotal = precio * cantidad;

                    // Rellenar el TextBox de subtotal con el valor calculado
                    TSubtotal.Text = subtotal.ToString("0.00");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingresa un precio válido.");
                }
            }
            else
            {
                TSubtotal.Clear();  // Limpiar el subtotal si no hay datos válidos
            }
        }

        private void CalcularTotalVenta()
        {
            decimal totalVenta = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (row.Cells["subtotal"].Value != null)
                    {
                        totalVenta += Convert.ToDecimal(row.Cells["subtotal"].Value);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error en el formato de los subtotales.");
                }
            }

            TTotal.Text = totalVenta.ToString("0.00");
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TProductoID.Text) || numericUpDown1.Value <= 0 || string.IsNullOrEmpty(TPrecioV.Text))
            {
                MessageBox.Show("Por favor, ingrese detalles válidos del producto.");
                return;
            }

            // Definir columnas si aún no están agregadas
            if (dataGridView1.Columns.Count == 0)
            {
                // Definir las columnas necesarias para el DataGridView
                dataGridView1.Columns.Add("idProducto", "ID Producto");
                dataGridView1.Columns.Add("nombreProducto", "Producto");
                dataGridView1.Columns.Add("cantidad", "Cantidad");
                dataGridView1.Columns.Add("precioVenta", "Precio Venta");
                dataGridView1.Columns.Add("subtotal", "Subtotal");

                dataGridView1.Columns["nombreProducto"].Width = 237;

                // Agregar columna de eliminación si no existe
                ConfigurarDataGridView();
            }

            // Obtener los valores del formulario
            int idProducto = Convert.ToInt32(TProductoID.Text);
            string nombreProducto = TProductoNombre.Text;
            int cantidad = (int)numericUpDown1.Value;
            decimal precioVenta = Convert.ToDecimal(TPrecioV.Text);
            decimal subtotal = cantidad * precioVenta;

            int stockDisponible = Convert.ToInt32(TStock.Text);

            if (cantidad > stockDisponible)
            {
                MessageBox.Show("No hay suficiente stock para este producto.");
                return;
            }

            // Insertar la fila con los datos en el DataGridView
            dataGridView1.Rows.Add(idProducto, nombreProducto, cantidad, precioVenta, subtotal);

            // Limpiar campos para el siguiente producto
            TProductoID.Clear();
            TProductoNombre.Clear();
            TStock.Clear();
            numericUpDown1.Value = 0;
            TPrecioV.Clear();
            TSubtotal.Clear();

            // Recalcular el total de la venta
            CalcularTotalVenta();
        }

        private bool ValidarDatosVenta()
        {
            // Verificar que el total de la venta sea un valor decimal positivo
            decimal totalVenta;
            if (!decimal.TryParse(TTotal.Text, out totalVenta) || totalVenta <= 0)
            {
                MessageBox.Show("El total de la venta debe ser un número decimal positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar que el ID del vendedor sea un valor entero positivo
            int idVendedor;
            if (!int.TryParse(TVendedorID.Text, out idVendedor) || idVendedor <= 0)
            {
                MessageBox.Show("El ID del vendedor debe ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar que el tipo de venta (ID) sea un valor entero positivo
            int idTipoVenta;
            var selectedValue = CBTipoV.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(selectedValue) || !int.TryParse(selectedValue, out idTipoVenta) || idTipoVenta <= 0)
            {
                MessageBox.Show("El tipo de venta seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar que el ID del cliente sea un valor entero positivo
            int idCliente;
            if (!int.TryParse(TClienteID.Text, out idCliente) || idCliente <= 0)
            {
                MessageBox.Show("El ID del cliente debe ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todas las validaciones son correctas
            return true;
        }

        private void BConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosVenta())
            {
                return; // Detener el proceso si los datos no son válidos
            }

            // Obtener los datos del formulario
            decimal totalVenta = Convert.ToDecimal(TTotal.Text);
            int idVendedor = Convert.ToInt32(TVendedorID.Text);
            int idTipoVenta = Convert.ToInt32(CBTipoV.SelectedValue);
            int idCliente = Convert.ToInt32(TClienteID.Text);

            // Iniciar la conexión con la base de datos
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                conexion.Open();
                SqlTransaction transaction = conexion.BeginTransaction();

                try
                {
                    string queryVenta = "INSERT INTO Venta (total_venta, id_usuario, id_tipo, id_cliente) OUTPUT INSERTED.id_venta VALUES (@totalVenta, @idUsuario, @idTipo, @idCliente)";
                    SqlCommand cmdVenta = new SqlCommand(queryVenta, conexion, transaction);
                    cmdVenta.Parameters.AddWithValue("@totalVenta", totalVenta);
                    cmdVenta.Parameters.AddWithValue("@idUsuario", idVendedor);
                    cmdVenta.Parameters.AddWithValue("@idTipo", idTipoVenta);
                    cmdVenta.Parameters.AddWithValue("@idCliente", idCliente);

                    // Obtener el id_venta generado
                    int idVenta = (int)cmdVenta.ExecuteScalar();

                    // Insertar los detalles de la venta en Detalle_Venta
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Saltar la fila nueva vacía
                        if (row.IsNewRow)
                        {
                            continue;
                        }

                        int idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                        decimal subtotal = Convert.ToDecimal(row.Cells["subtotal"].Value);

                        string queryDetalle = "INSERT INTO Detalle_Venta (cantidad, id_producto, subtotal, id_venta) OUTPUT INSERTED.id_detalle VALUES (@cantidad, @idProducto, @subtotal, @idVenta)";
                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, transaction);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdDetalle.Parameters.AddWithValue("@idProducto", idProducto);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", subtotal);
                        cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                        cmdDetalle.ExecuteNonQuery();

                        // Descontar el stock en la tabla Producto
                        string queryUpdateStock = "UPDATE Producto SET stock = stock - @cantidad WHERE id_producto = @idProducto";
                        SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, conexion, transaction);
                        cmdUpdateStock.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdUpdateStock.Parameters.AddWithValue("@idProducto", idProducto);
                        cmdUpdateStock.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Venta confirmada con éxito.");

                    // Limpiar el DataGridView y restablecer valores
                    dataGridView1.Rows.Clear();
                    TTotal.Clear(); 
                    TClienteID.Clear();
                    TClienteNombre.Clear();
                    TProductoID.Clear();
                    TProductoNombre.Clear();
                    TStock.Clear();
                    TPrecioV.Clear();
                    TSubtotal.Clear();
                    numericUpDown1.Value = 0;

                    this.DialogResult = DialogResult.OK;
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al confirmar la venta: " + ex.Message);
                }
            }
        }

        private void ConfigurarDataGridView()
        {
            if (dataGridView1.Columns["eliminar"] == null)
            {
                // Crear la columna de imagen para eliminar productos
                DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
                colEliminar.Name = "eliminar";
                colEliminar.HeaderText = "Eliminar";
                colEliminar.Image = Properties.Resources.delete_sign;
                colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajuste de imagen
                colEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //colEliminar.Width = 60;
                colEliminar.DefaultCellStyle = null;
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colEliminar.DefaultCellStyle = style;
                dataGridView1.Columns.Add(colEliminar);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la columna presionada es la de eliminación
            if (e.ColumnIndex == dataGridView1.Columns["eliminar"].Index && e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                // Verificar si la fila no está vacía y no es una fila de nueva entrada
                bool isRowEmpty = row.Cells.Cast<DataGridViewCell>().All(cell => cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()));
                if (isRowEmpty || row.IsNewRow)
                {
                    // Si la fila está vacía o es una nueva fila, salir del método sin hacer nada
                    return;
                }

                // Confirmación antes de eliminar
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);  // Eliminar la fila seleccionada
                    CalcularTotalVenta(); // Recalcular el total de la venta
                }
            }
        }

        private void CargarDatos()
        {
            int idVendedor = UsuarioInfo.IDUsuario;
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                string query = "SELECT v.id_venta, v.fecha_venta, v.total_venta, uv.descripcion AS tipo_venta, p.nombre AS cliente_nombre, p.apellido AS cliente_apellido " +
                    "FROM Venta v " +
                    "JOIN Tipo_Venta uv ON v.id_tipo = uv.id_tipo " +
                    "JOIN Cliente c ON v.id_cliente = c.id_cliente " +
                    "JOIN Persona p ON c.id_cliente = p.id_persona " +
                    "WHERE v.id_usuario = @idVendedor";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.SelectCommand.Parameters.AddWithValue("@idVendedor", idVendedor);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                dataGridView2.Columns["id_venta"].HeaderText = "ID Venta";
                dataGridView2.Columns["fecha_venta"].HeaderText = "Fecha";
                dataGridView2.Columns["total_venta"].HeaderText = "Total Venta";
                dataGridView2.Columns["tipo_venta"].HeaderText = "Método Pago";
                dataGridView2.Columns["cliente_nombre"].HeaderText = "Nombre Cliente";
                dataGridView2.Columns["cliente_apellido"].HeaderText = "Apellido Cliente";

                dataGridView2.Columns["id_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns["fecha_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns["total_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns["tipo_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns["cliente_nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView2.Columns["cliente_apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            string filtro = TBuscarVenta.Text;

            // Verificar si hay algún filtro ingresado
            if (string.IsNullOrWhiteSpace(filtro))
            {
                MessageBox.Show("Por favor, ingrese un criterio de búsqueda.");
                return;
            }

            // Obtener la columna seleccionada en el ComboBox
            string columnaSeleccionada = CBFiltro.SelectedItem.ToString();
            string columnaBD = "";

            // Mapear el nombre del filtro a la columna de la base de datos
            switch (columnaSeleccionada)
            {
                case "ID Venta":
                    columnaBD = "v.id_venta";
                    break;
                case "Fecha":
                    columnaBD = "CAST(v.fecha_venta AS VARCHAR)";
                    break;
                case "Total Venta":
                    columnaBD = "CAST(v.total_venta AS VARCHAR)";
                    break;
                case "Método Pago":
                    columnaBD = "uv.descripcion COLLATE Latin1_General_CI_AI";
                    break;
                case "Nombre Cliente":
                    columnaBD = "p.nombre COLLATE Latin1_General_CI_AI";
                    break;
                case "Apellido Cliente":
                    columnaBD = "p.apellido COLLATE Latin1_General_CI_AI";
                    break;
            }

            // Definir la consulta SQL basándose en la columna seleccionada
            int idVendedor = UsuarioInfo.IDUsuario;
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                string query = $@"
                    SELECT v.id_venta, v.fecha_venta, v.total_venta, uv.descripcion AS tipo_venta, 
                    p.nombre AS cliente_nombre, p.apellido AS cliente_apellido
                    FROM Venta v
                    JOIN Tipo_Venta uv ON v.id_tipo = uv.id_tipo
                    JOIN Cliente c ON v.id_cliente = c.id_cliente
                    JOIN Persona p ON c.id_cliente = p.id_persona
                    WHERE v.id_usuario = @idVendedor AND {columnaBD} LIKE @filtro";

                // Crear un adaptador de datos para ejecutar la consulta
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.SelectCommand.Parameters.AddWithValue("@idVendedor", idVendedor);
                // Agregar el parámetro del filtro con wildcard para buscar coincidencias parciales
                da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                // Crear una tabla de datos para almacenar los resultados
                DataTable dt = new DataTable();

                // Llenar la tabla de datos con los resultados
                da.Fill(dt);

                // Asignar los resultados al DataGridView
                dataGridView2.DataSource = dt;

                // Ajustar los encabezados de las columnas para que coincidan con CargarDatos
                dataGridView2.Columns["id_venta"].HeaderText = "ID Venta";
                dataGridView2.Columns["fecha_venta"].HeaderText = "Fecha";
                dataGridView2.Columns["total_venta"].HeaderText = "Total Venta";
                dataGridView2.Columns["tipo_venta"].HeaderText = "Método Pago";
                dataGridView2.Columns["cliente_nombre"].HeaderText = "Nombre Cliente";
                dataGridView2.Columns["cliente_apellido"].HeaderText = "Apellido Cliente";

                // Verificar si se encontraron resultados
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas que coincidan con el criterio de búsqueda.");
                    CargarDatos();
                }
            }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el TextBox de búsqueda y seleccionar la primera opción del ComboBox
            TBuscarVenta.Clear();
            CBFiltro.SelectedIndex = 0;

            // Cargar todos los productos sin aplicar ningún filtro
            CargarDatos();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en una fila válida
            if (e.RowIndex >= 0)
            {
                // Verificar si el valor en la celda "id_venta" no es DBNull
                if (dataGridView2.Rows[e.RowIndex].Cells["id_venta"].Value != DBNull.Value)
                {
                    // Convertir el valor a int solo si la celda tiene un valor válido
                    int idVenta = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["id_venta"].Value);

                    // Abrir el formulario de detalles de la venta y pasar el idVenta
                    DetalleVentaForm detalleVentaForm = new DetalleVentaForm(idVenta);
                    detalleVentaForm.ShowDialog();
                }
            }
        }

    }
}
