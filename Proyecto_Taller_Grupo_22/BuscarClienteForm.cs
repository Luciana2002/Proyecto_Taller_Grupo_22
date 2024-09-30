using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_Taller_Grupo_22
{
    public partial class BuscarClienteForm : Form
    {
        // Variables para almacenar los datos seleccionados
        public string IdClienteSeleccionado { get; private set; }
        public string NombreClienteSeleccionado { get; private set; }
        //public string ApellidoClienteSeleccionado { get; private set; }

        public BuscarClienteForm()
        {
            InitializeComponent();
        }

        private void CargarClientes()
        {
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                string query = "SELECT p.id_persona, p.nombre, p.apellido, p.estado, p.email, p.sexo, p.telefono, p.cumpleaños, p.dni " +
                    "FROM Persona p " +
                    "JOIN Cliente c ON p.id_persona = c.id_cliente " +
                    "WHERE p.estado = 'A'";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            string filtro = TBuscarCliente.Text;

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

            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                // Definir la consulta, construyendo dinámicamente la columna de filtro
                string query = $@"SELECT p.id_persona, p.nombre, p.apellido, p.estado, p.email, p.sexo, p.telefono, p.cumpleaños, p.dni
                          FROM Persona p 
                          JOIN Cliente c ON p.id_persona = c.id_cliente
                          WHERE p.{columnaSeleccionada} COLLATE Latin1_General_CI_AI LIKE @filtro AND p.estado = 'A'";

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
                    MessageBox.Show("No se encontraron clientes que coincidan con el criterio de búsqueda.");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener los datos de la fila seleccionada
            IdClienteSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["id_persona"].Value.ToString();
            NombreClienteSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            //ApellidoClienteSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["apellido"].Value.ToString();

            // Cerrar el formulario de búsqueda y regresar al formulario de ventas
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con los nombres de las columnas de la tabla Persona
            CBFiltro.Items.Add("id_persona");
            CBFiltro.Items.Add("nombre");
            CBFiltro.Items.Add("apellido");
            CBFiltro.Items.Add("estado");
            CBFiltro.Items.Add("email");
            CBFiltro.Items.Add("sexo");
            CBFiltro.Items.Add("telefono");
            CBFiltro.Items.Add("cumpleaños");
            CBFiltro.Items.Add("dni");

            // Seleccionar por defecto una opción, por ejemplo "nombre"
            CBFiltro.SelectedIndex = 0; // Selecciona el primer elemento ("nombre")

            // Cargar todos los clientes al iniciar el formulario
            CargarClientes();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el TextBox de búsqueda y seleccionar la primera opción del ComboBox
            TBuscarCliente.Clear();
            CBFiltro.SelectedIndex = 0;

            // Cargar todos los clientes sin aplicar ningún filtro
            CargarClientes();
        }
    }
}
