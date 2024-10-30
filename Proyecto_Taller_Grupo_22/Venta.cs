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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
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
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id_venta"].HeaderText = "ID Venta";
                dataGridView1.Columns["fecha_venta"].HeaderText = "Fecha";
                dataGridView1.Columns["total_venta"].HeaderText = "Total Venta";
                dataGridView1.Columns["tipo_venta"].HeaderText = "Método Pago";
                dataGridView1.Columns["cliente_nombre"].HeaderText = "Nombre Cliente";
                dataGridView1.Columns["cliente_apellido"].HeaderText = "Apellido Cliente";

                dataGridView1.Columns["id_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["fecha_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["total_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["tipo_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["cliente_nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["cliente_apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            var NuevaVenta = new NuevaVenta();
            //NuevaVenta.ShowDialog();
            var resultado = NuevaVenta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                // Llamar a CargarDatos() para actualizar la lista de ventas
                CargarDatos();
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
                dataGridView1.DataSource = dt;

                // Ajustar los encabezados de las columnas para que coincidan con CargarDatos
                dataGridView1.Columns["id_venta"].HeaderText = "ID Venta";
                dataGridView1.Columns["fecha_venta"].HeaderText = "Fecha";
                dataGridView1.Columns["total_venta"].HeaderText = "Total Venta";
                dataGridView1.Columns["tipo_venta"].HeaderText = "Método Pago";
                dataGridView1.Columns["cliente_nombre"].HeaderText = "Nombre Cliente";
                dataGridView1.Columns["cliente_apellido"].HeaderText = "Apellido Cliente";

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en una fila válida
            if (e.RowIndex >= 0)
            {
                // Verificar si el valor en la celda "id_venta" no es DBNull
                if (dataGridView1.Rows[e.RowIndex].Cells["id_venta"].Value != DBNull.Value)
                {
                    // Convertir el valor a int solo si la celda tiene un valor válido
                    int idVenta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_venta"].Value);

                    // Abrir el formulario de detalles de la venta y pasar el idVenta
                    DetalleVentaForm detalleVentaForm = new DetalleVentaForm(idVenta);
                    detalleVentaForm.ShowDialog();
                }
            }
        }

    }
}
