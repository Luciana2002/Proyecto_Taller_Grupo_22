using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_Taller_Grupo_22
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            RBMasculino.Checked = false;
            RBFemenino.Checked = false;
            CargarDatos("A");
        }

        private void CargarDatos(string estado)
        {
            try
            {
                // Consulta SQL 
                string query = @"SELECT p.id_persona, p.nombre, p.apellido, p.email, p.sexo, p.telefono, p.cumpleaños, p.dni
                         FROM Persona p
                         INNER JOIN Cliente c ON p.id_persona = c.id_cliente
                         WHERE p.estado = @estado";

                // Usamos SqlConnection para conectarnos a la base de datos
                using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
                {
                    // Usamos SqlDataAdapter para ejecutar la consulta y llenar el DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conexion);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@estado", estado);
                    DataTable dataTable = new DataTable();

                    // Llenamos el DataTable con los datos
                    dataAdapter.Fill(dataTable);

                    // Asignamos el DataTable al DataGridView
                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["id_persona"].HeaderText = "ID";
                    dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                    dataGridView1.Columns["apellido"].HeaderText = "Apellido";
                    dataGridView1.Columns["email"].HeaderText = "Email";
                    dataGridView1.Columns["sexo"].HeaderText = "Sexo";
                    dataGridView1.Columns["telefono"].HeaderText = "Teléfono";
                    dataGridView1.Columns["cumpleaños"].HeaderText = "Cumpleaños";
                    dataGridView1.Columns["dni"].HeaderText = "DNI";

                    dataGridView1.Columns["id_persona"].Width = 80;
                    //dataGridView1.Columns["id_persona"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["sexo"].Width = 140;
                    //dataGridView1.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["sexo"].Width = 80;
                    //dataGridView1.Columns["sexo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["telefono"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["cumpleaños"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["dni"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void CargarTodosLosDatos()
        {
            try
            {
                string query = @"SELECT p.id_persona, p.nombre, p.apellido, p.email, p.sexo, p.telefono, p.cumpleaños, p.dni 
                         FROM Persona p
                         INNER JOIN Cliente c ON p.id_persona = c.id_cliente"; // No hay filtro

                using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conexion);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns["id_persona"].HeaderText = "ID";
                    dataGridView1.Columns["nombre"].HeaderText = "Nombre";
                    dataGridView1.Columns["apellido"].HeaderText = "Apellido";
                    dataGridView1.Columns["email"].HeaderText = "Email";
                    dataGridView1.Columns["sexo"].HeaderText = "Sexo";
                    dataGridView1.Columns["telefono"].HeaderText = "Teléfono";
                    dataGridView1.Columns["cumpleaños"].HeaderText = "Cumpleaños";
                    dataGridView1.Columns["dni"].HeaderText = "DNI";

                    dataGridView1.Columns["id_persona"].Width = 80;
                    //dataGridView1.Columns["id_persona"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["sexo"].Width = 140;
                    //dataGridView1.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["sexo"].Width = 80;
                    //dataGridView1.Columns["sexo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["telefono"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["cumpleaños"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["dni"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void BTodos_Click(object sender, EventArgs e)
        {
            CargarTodosLosDatos(); // Cargar todos los usuarios
        }
        private void BActivos_Click(object sender, EventArgs e) 
        {
            CargarDatos("A"); // Filtrar solo los usuarios activos
        }
        private void BInactivos_Click(object sender, EventArgs e)
        {
            CargarDatos("I"); // Filtrar solo los usuarios inactivos
        }

        private bool ValidarDatosFormulario()
        {
            // Obtener los valores de los TextBox
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string email = TEmail.Text;
            string telefono = TTelefono.Text;
            string cumpleStr = DTPCumple.Text;
            string dniStr = TDNI.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(cumpleStr) ||
                string.IsNullOrWhiteSpace(dniStr))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el formato del cumpleaños
            DateTime cumpleaños;
            if (!DateTime.TryParse(cumpleStr, out cumpleaños))
            {
                MessageBox.Show("El formato de la fecha es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el formato del DNI
            int dni;
            if (!int.TryParse(dniStr, out dni) || dni < 1000000 || dni > 99999999) // Según restricción CK_dni
            {
                MessageBox.Show("El DNI debe ser un número entre 1.000.000 y 99.999.999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el formato del nombre (solo letras y espacios)
            if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[A-Za-záéíóúÁÉÍÓÚüÜñÑ ]+$"))
            {
                MessageBox.Show("El nombre solo puede contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el formato del apellido (solo letras y espacios)
            if (!System.Text.RegularExpressions.Regex.IsMatch(apellido, @"^[A-Za-záéíóúÁÉÍÓÚüÜñÑz ]+$"))
            {
                MessageBox.Show("El apellido solo puede contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el formato del teléfono (números, espacios, +, -, %)
            if (!System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^[0-9 +\-]*$"))
            {
                MessageBox.Show("El teléfono solo puede contener números, espacios y los símbolos + y -.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar el formato del sexo (M o F)
            string sexo = "";
            if (RBMasculino.Checked)
            {
                sexo = "M";
            }
            else if (RBFemenino.Checked)
            {
                sexo = "F";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione el sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todas las validaciones son correctas
            return true;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosFormulario())
            {
                return; // Detener el proceso si los datos no son válidos
            }

            // Obtener los valores de los TextBox
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string email = TEmail.Text;
            string telefono = TTelefono.Text;
            DateTime cumpleaños = DateTime.Parse(DTPCumple.Text);
            int dni = int.Parse(TDNI.Text);

            // Capturar el valor del sexo seleccionado
            string sexo = RBMasculino.Checked ? "M" : "F";

            // Llamar a la función de guardar (insertar) datos
            bool exito = GuardarDatosEnBaseDeDatos(null, nombre, apellido, email, telefono, cumpleaños, dni, sexo);

            if (exito)
            {
                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatos("A"); // Recargar el grid o datos después de agregar
            }
        }

        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TEmail.Clear();
            TTelefono.Clear();
            DTPCumple.Value = DateTime.Now;
            TDNI.Clear();
            RBMasculino.Checked = false;
            RBFemenino.Checked = false;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty; // Limpiar cada TextBox
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
                string emailActual = row.Cells["email"].Value.ToString();
                string dniActual = row.Cells["dni"].Value.ToString();

                // Copiar los datos de las celdas a los TextBox
                TNombre.Text = row.Cells["nombre"].Value.ToString();
                TApellido.Text = row.Cells["apellido"].Value.ToString();
                TEmail.Text = row.Cells["email"].Value.ToString();
                TTelefono.Text = row.Cells["telefono"].Value.ToString();
                DTPCumple.Value = Convert.ToDateTime(row.Cells["cumpleaños"].Value);
                TDNI.Text = row.Cells["dni"].Value.ToString();

                // Establecer el sexo
                string sexo = row.Cells["sexo"].Value.ToString();
                RBMasculino.Checked = sexo == "M";
                RBFemenino.Checked = sexo == "F";
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

        // Evento del botón "Aceptar" para guardar los cambios
        private void BAceptar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que haya una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no hay filas seleccionadas
            }

            // Validar los datos del formulario y pasar el email y dni actuales
            if (!ValidarDatosFormulario())
            {
                return; // Salir si hay un error de validación
            }

            // Aquí ya puedes asumir que la validación fue exitosa
            // Obtener la fila seleccionada
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = (int)row.Cells["id_persona"].Value; // Obtener el ID de la persona

            // Recoger los valores de los TextBox
            string nombre = TNombre.Text;
            string apellido = TApellido.Text;
            string email = TEmail.Text;
            string telefono = TTelefono.Text;
            DateTime cumpleaños = DateTime.Parse(DTPCumple.Text);
            int dni = int.Parse(TDNI.Text);
            string sexo = RBMasculino.Checked ? "M" : "F";

            // Actualizar los datos en la base de datos
            bool success = GuardarDatosEnBaseDeDatos(id, nombre, apellido, email, telefono, cumpleaños, dni, sexo);

            // Mostrar mensaje según el resultado
            if (success)
            {
                MessageBox.Show("Los datos han sido actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos("A"); // Refrescar el DataGridView para ver los cambios
                LimpiarCampos(); // Limpiar los campos después de la actualización
            }

        }

        private bool GuardarDatosEnBaseDeDatos(int? idPersona, string nombre, string apellido, string email, string telefono, DateTime cumple, int dni, string sexo)
        {
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                conexion.Open();
                using (SqlTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Validar si DNI, Email o Teléfono ya existen en la base de datos
                        string campoDuplicado = ExistePersonaConDatosDuplicados(email, dni, telefono, conexion, transaction, idPersona);
                        if (campoDuplicado != null)
                        {
                            MessageBox.Show($"El {campoDuplicado} ya está registrado. Por favor, utiliza otro valor.", "Error de Unicidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        if (idPersona == null)
                        {
                            // Insertar en Persona
                            string queryInsertPersona = "INSERT INTO Persona (nombre, apellido, email, sexo, telefono, cumpleaños, dni) " +
                                                        "OUTPUT INSERTED.id_persona " +
                                                        "VALUES (@nombre, @apellido, @correo, @sexo, @telefono, @cumple, @dni)";

                            using (SqlCommand cmdInsertPersona = new SqlCommand(queryInsertPersona, conexion, transaction))
                            {
                                cmdInsertPersona.Parameters.AddWithValue("@nombre", nombre);
                                cmdInsertPersona.Parameters.AddWithValue("@apellido", apellido);
                                cmdInsertPersona.Parameters.AddWithValue("@correo", email);
                                cmdInsertPersona.Parameters.AddWithValue("@sexo", sexo);
                                cmdInsertPersona.Parameters.AddWithValue("@telefono", telefono);
                                cmdInsertPersona.Parameters.AddWithValue("@cumple", cumple);
                                cmdInsertPersona.Parameters.AddWithValue("@dni", dni);

                                idPersona = (int)cmdInsertPersona.ExecuteScalar();
                            }

                            // Insertar en Cliente
                            string queryInsertCliente = "INSERT INTO Cliente (id_cliente) " +
                                                        "VALUES (@id_persona)";
                            using (SqlCommand cmdInsertCliente = new SqlCommand(queryInsertCliente, conexion, transaction))
                            {
                                cmdInsertCliente.Parameters.AddWithValue("@id_persona", idPersona);
                                cmdInsertCliente.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Actualizar Persona
                            string queryUpdatePersona = "UPDATE Persona SET nombre = @nombre, apellido = @apellido, email = @correo, sexo = @sexo, telefono = @telefono, cumpleaños = @cumple, dni = @dni WHERE id_persona = @id_persona";

                            using (SqlCommand cmdUpdatePersona = new SqlCommand(queryUpdatePersona, conexion, transaction))
                            {
                                cmdUpdatePersona.Parameters.AddWithValue("@id_persona", idPersona);
                                cmdUpdatePersona.Parameters.AddWithValue("@nombre", nombre);
                                cmdUpdatePersona.Parameters.AddWithValue("@apellido", apellido);
                                cmdUpdatePersona.Parameters.AddWithValue("@correo", email);
                                cmdUpdatePersona.Parameters.AddWithValue("@sexo", sexo);
                                cmdUpdatePersona.Parameters.AddWithValue("@telefono", telefono);
                                cmdUpdatePersona.Parameters.AddWithValue("@cumple", cumple);
                                cmdUpdatePersona.Parameters.AddWithValue("@dni", dni);
                                cmdUpdatePersona.ExecuteNonQuery();
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

        private string ExistePersonaConDatosDuplicados(string email, int dni, string telefono, SqlConnection conexion, SqlTransaction transaction, int? idPersona = null)
        {
            // Verificar email, excluyendo el registro actual si idPersona está definido
            string queryEmail = "SELECT COUNT(*) FROM Persona WHERE email = @correo" + (idPersona.HasValue ? " AND id_persona <> @id_persona" : "");
            using (SqlCommand cmdEmail = new SqlCommand(queryEmail, conexion, transaction))
            {
                cmdEmail.Parameters.AddWithValue("@correo", email);
                if (idPersona.HasValue)
                    cmdEmail.Parameters.AddWithValue("@id_persona", idPersona.Value);

                int emailCount = (int)cmdEmail.ExecuteScalar();
                if (emailCount > 0) return "Email";
            }

            // Verificar dni
            string queryDNI = "SELECT COUNT(*) FROM Persona WHERE dni = @dni" + (idPersona.HasValue ? " AND id_persona <> @id_persona" : "");
            using (SqlCommand cmdDNI = new SqlCommand(queryDNI, conexion, transaction))
            {
                cmdDNI.Parameters.AddWithValue("@dni", dni);
                if (idPersona.HasValue)
                    cmdDNI.Parameters.AddWithValue("@id_persona", idPersona.Value);

                int dniCount = (int)cmdDNI.ExecuteScalar();
                if (dniCount > 0) return "DNI";
            }

            // Verificar telefono
            string queryTelefono = "SELECT COUNT(*) FROM Persona WHERE telefono = @telefono" + (idPersona.HasValue ? " AND id_persona <> @id_persona" : "");
            using (SqlCommand cmdTelefono = new SqlCommand(queryTelefono, conexion, transaction))
            {
                cmdTelefono.Parameters.AddWithValue("@telefono", telefono);
                if (idPersona.HasValue)
                    cmdTelefono.Parameters.AddWithValue("@id_persona", idPersona.Value);

                int telefonoCount = (int)cmdTelefono.ExecuteScalar();
                if (telefonoCount > 0) return "Teléfono";
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
                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != DBNull.Value)
                    {
                        // Obtén el ID de la persona desde la fila seleccionada
                        int idCliente = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                        // Variable para almacenar el estado actual
                        string estadoActual = "";

                        // Conectar a la base de datos para verificar el estado actual
                        using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
                        {
                            conexion.Open();
                            // Consulta para obtener el estado actual desde la base de datos
                            string queryEstado = "SELECT estado FROM Persona WHERE id_persona = @idCliente";
                            using (SqlCommand comando = new SqlCommand(queryEstado, conexion))
                            {
                                comando.Parameters.AddWithValue("@idCliente", idCliente);
                                SqlDataReader reader = comando.ExecuteReader();
                                if (reader.Read())
                                {
                                    estadoActual = reader["estado"].ToString();
                                }
                            }
                        }

                        string nuevoEstado = estadoActual == "A" ? "I" : "A";

                        // Actualiza el estado en la base de datos
                        UpdateStatusInDatabase(idCliente, nuevoEstado);
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

        private void UpdateStatusInDatabase(int idCliente, string nuevoEstado)
        {
            using (SqlConnection conexion = new SqlConnection("server=.; database=taller_db_1; integrated security=true"))
            {
                conexion.Open();
                using (SqlTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        string query = "UPDATE Persona SET estado = @estado WHERE id_persona = @id_cliente";

                        using (SqlCommand cmdUpdateCliente = new SqlCommand(query, conexion, transaction))
                        {

                            cmdUpdateCliente.Parameters.AddWithValue("@id_cliente", idCliente);
                            cmdUpdateCliente.Parameters.AddWithValue("@estado", nuevoEstado);
                            cmdUpdateCliente.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("El estado ha sido actualizado correctamente.");
                        CargarDatos("A");
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
