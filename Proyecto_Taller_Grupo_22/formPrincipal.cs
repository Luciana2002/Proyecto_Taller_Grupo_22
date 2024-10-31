using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_Grupo_22
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            ConfigurarBotones();
        }

        private void ConfigurarBotones()
        {
            // Verificamos el perfil del usuario actual
            string perfil = UsuarioInfo.Perfil;

            switch (perfil)
            {
                case "Administrador":
                    DeshabilitarBoton(BClientes, PBCliente);
                    DeshabilitarBoton(BVentas, PBVenta);
                    DeshabilitarBoton(BProductos, PBProducto);
                    break;

                case "Gerente":
                    DeshabilitarBoton(BVentas, PBVenta);
                    DeshabilitarBoton(BEmpleados, PBEmpleado);
                    break;

                case "Empleado":
                    DeshabilitarBoton(BEmpleados, PBEmpleado);
                    DeshabilitarBoton(BProductos, PBProducto);
                    DeshabilitarBoton(BBackUp, PBBackUp);
                    break;

                default:
                    MessageBox.Show("Perfil no reconocido. Contacte al administrador.");
                    break;
            }
        }

        // Método para deshabilitar un botón y asignar el evento Paint
        private void DeshabilitarBoton(Button btn, PictureBox pictureBox)
        {
            btn.Enabled = false;
            btn.Paint += new PaintEventHandler(DrawDisabledButton);
            pictureBox.Image = ConvertToGrayscale(pictureBox.Image);
            pictureBox.Enabled = false;

        }

        // Evento para cambiar el color del botón cuando está deshabilitado
        private void DrawDisabledButton(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (!btn.Enabled)
            {
                // Si el botón tiene una imagen, dibujarla en escala de grises
                if (btn.Image != null)
                {
                    Image grayImage = ConvertToGrayscale(btn.Image); // Convertir a gris preservando transparencia
                    e.Graphics.DrawImage(grayImage, (btn.Width - grayImage.Width) / 2, (btn.Height - grayImage.Height) / 2);
                }
            }
        }

        // Método para convertir una imagen a escala de grises
        private Image ConvertToGrayscale(Image original)
        {
            // Crea un nuevo bitmap con las mismas dimensiones que la imagen original
            Bitmap grayImage = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    // Obtén el color original del píxel
                    Color originalColor = ((Bitmap)original).GetPixel(x, y);

                    // Si el píxel es transparente, preserva la transparencia
                    if (originalColor.A == 0)
                    {
                        grayImage.SetPixel(x, y, Color.Transparent);
                    }
                    else
                    {
                        // Calcula el valor en escala de grises
                        int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                        Color grayColor = Color.FromArgb(originalColor.A, grayScale, grayScale, grayScale); // Mantiene el canal alfa
                        grayImage.SetPixel(x, y, grayColor);
                    }
                }
            }

            return grayImage;
        }

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Si ya hay algún formulario abierto, cerrarlo
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls[0].Dispose();

            // Configurar el formulario hijo
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agregar el formulario hijo al panel
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;

            // Asegurarse de que el formulario esté al frente
            formularioHijo.BringToFront();
            this.panelContenedor.BringToFront(); // Asegurar que el panel esté por delante de otros controles

            formularioHijo.Show();
        }

        private void BUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Usuario());
        }

        private void PBUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Usuario());
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Cliente());
        }

        private void PBCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Cliente());
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Venta()); 
        }

        private void PBVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Venta());
        }

        private void BReportes_Click(object sender, EventArgs e)
        {
            Form reporteForm;

            // Verificamos el perfil del usuario actual
            string perfil = UsuarioInfo.Perfil;

            switch (perfil)
            {
                case "Administrador":
                    reporteForm = new ReporteA(); // Asegúrate de que esta clase exista
                    break;

                case "Gerente":
                    reporteForm = new ReporteG(); // Asegúrate de que esta clase exista
                    break;

                case "Empleado":
                    reporteForm = new ReporteE(); // Asegúrate de que esta clase exista
                    break;

                default:
                    MessageBox.Show("Perfil no reconocido. Contacte al administrador.");
                    return;
            }

            AbrirFormularioEnPanel(reporteForm);
        }

        private void PBReporte_Click(object sender, EventArgs e)
        {
            BReportes_Click(sender, e); // Llama al mismo método que el botón
        }

        private void BEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Empleado());
        }

        private void PBEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Empleado());
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Producto());
        }

        private void PBProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Producto());
        }

        private void BBackup_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Backup());
        }

        private void PBBackup_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Backup());
        }

        private void PBSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();  // Oculta el formulario actual
            var Form1 = new Form1();  // Muestra el formulario de login nuevamente
            Form1.Show();
        }
    }
}
