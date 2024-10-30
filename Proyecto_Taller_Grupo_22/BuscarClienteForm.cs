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
                string query = "SELECT p.id_persona, p.nombre, p.apellido, p.email, p.dni " +
                    "FROM Persona p " +
                    "JOIN Cliente c ON p.id_persona = c.id_cliente " +
                    "WHERE p.estado = 'A'";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id_persona"].HeaderText = "ID Cliente";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["apellido"].HeaderText = "Apellido";
                dataGridView1.Columns["email"].HeaderText = "Email";
                dataGridView1.Columns["dni"].HeaderText = "DNI";

                dataGridView1.Columns["id_persona"].Width = 97;
                dataGridView1.Columns["nombre"].Width = 130;
                dataGridView1.Columns["apellido"].Width = 130;
                dataGridView1.Columns["email"].Width = 210;
                dataGridView1.Columns["dni"].Width = 130;
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
            ComboBoxItem itemSeleccionado = (ComboBoxItem)CBFiltro.SelectedItem;
            string columnaSeleccionada = itemSeleccionado?.Value;

            // Verificar si hay una columna seleccionada
            if (string.IsNullOrEmpty(columnaSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione un campo de búsqueda.");
                return;
            }

            // Determinar si la columna es de texto o numérica
            bool isTextColumn = columnaSeleccionada == "nombre" || columnaSeleccionada == "apellido" || columnaSeleccionada == "email";

            // Construir la consulta con o sin COLLATE según el tipo de columna
            string query = $@"
                SELECT p.id_persona, p.nombre, p.apellido, p.email, p.dni
                FROM Persona p
                JOIN Cliente c ON p.id_persona = c.id_cliente
                WHERE {(isTextColumn ? $"p.{columnaSeleccionada} COLLATE Latin1_General_CI_AI LIKE @filtro" : $"CAST(p.{columnaSeleccionada} AS VARCHAR) LIKE @filtro")}
                AND p.estado = 'A'";

            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);

                // Agregar el parámetro del filtro con wildcard para buscar coincidencias parciales
                da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns["id_persona"].HeaderText = "ID Cliente";
                dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["apellido"].HeaderText = "Apellido";
                dataGridView1.Columns["email"].HeaderText = "Email";
                dataGridView1.Columns["dni"].HeaderText = "DNI";

                dataGridView1.Columns["id_persona"].Width = 97;
                dataGridView1.Columns["nombre"].Width = 130;
                dataGridView1.Columns["apellido"].Width = 130;
                dataGridView1.Columns["email"].Width = 210;
                dataGridView1.Columns["dni"].Width = 130;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes que coincidan con el criterio de búsqueda.");
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
            IdClienteSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["id_persona"].Value.ToString();
            NombreClienteSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            //ApellidoClienteSeleccionado = dataGridView1.Rows[e.RowIndex].Cells["apellido"].Value.ToString();

            // Cerrar el formulario de búsqueda y regresar al formulario de ventas
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con los nombres amigables para los filtros
            CBFiltro.Items.Add(new ComboBoxItem("ID Cliente", "id_persona"));
            CBFiltro.Items.Add(new ComboBoxItem("Nombre", "nombre"));
            CBFiltro.Items.Add(new ComboBoxItem("Apellido", "apellido"));
            CBFiltro.Items.Add(new ComboBoxItem("Email", "email"));
            CBFiltro.Items.Add(new ComboBoxItem("DNI", "dni"));

            // Seleccionar por defecto una opción, por ejemplo "Nombre"
            CBFiltro.SelectedIndex = 0; // Selecciona el primer elemento ("ID Cliente")

            // Cargar todos los clientes al iniciar el formulario
            CargarClientes();
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
            TBuscarCliente.Clear();
            CBFiltro.SelectedIndex = 0;

            // Cargar todos los clientes sin aplicar ningún filtro
            CargarClientes();
        }
    }
}
