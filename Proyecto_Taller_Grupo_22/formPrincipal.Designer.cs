namespace Proyecto_Taller_Grupo_22
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BUsuario = new Button();
            BVentas = new Button();
            BProductos = new Button();
            BClientes = new Button();
            BEmpleados = new Button();
            panel1 = new Panel();
            PBEmpleado = new PictureBox();
            PBBackUp = new PictureBox();
            BBackUp = new Button();
            PBProducto = new PictureBox();
            PBCliente = new PictureBox();
            PBVenta = new PictureBox();
            PBReporte = new PictureBox();
            PBSalir = new PictureBox();
            PBUsuario = new PictureBox();
            BReportes = new Button();
            panelContenedor = new Panel();
            pictureBox8 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBEmpleado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBBackUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBReporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBUsuario).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // BUsuario
            // 
            BUsuario.BackColor = Color.Plum;
            BUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            BUsuario.Font = new Font("Segoe UI", 14.25F);
            BUsuario.ForeColor = SystemColors.ActiveCaptionText;
            BUsuario.Location = new Point(13, 16);
            BUsuario.Margin = new Padding(3, 4, 3, 4);
            BUsuario.Name = "BUsuario";
            BUsuario.Size = new Size(129, 107);
            BUsuario.TabIndex = 0;
            BUsuario.Text = "Usuario";
            BUsuario.TextAlign = ContentAlignment.BottomCenter;
            BUsuario.UseVisualStyleBackColor = false;
            BUsuario.Click += BUsuario_Click;
            // 
            // BVentas
            // 
            BVentas.BackColor = Color.Plum;
            BVentas.Font = new Font("Segoe UI", 14.25F);
            BVentas.Location = new Point(13, 252);
            BVentas.Margin = new Padding(3, 4, 3, 4);
            BVentas.Name = "BVentas";
            BVentas.Size = new Size(129, 111);
            BVentas.TabIndex = 1;
            BVentas.Text = "Ventas";
            BVentas.TextAlign = ContentAlignment.BottomCenter;
            BVentas.UseVisualStyleBackColor = false;
            BVentas.Click += BVentas_Click;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.Plum;
            BProductos.Font = new Font("Segoe UI", 14.25F);
            BProductos.Location = new Point(13, 600);
            BProductos.Margin = new Padding(3, 4, 3, 4);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(129, 113);
            BProductos.TabIndex = 2;
            BProductos.Text = "Productos";
            BProductos.TextAlign = ContentAlignment.BottomRight;
            BProductos.UseVisualStyleBackColor = false;
            BProductos.Click += BProductos_Click;
            // 
            // BClientes
            // 
            BClientes.BackColor = Color.Plum;
            BClientes.Font = new Font("Segoe UI", 14.25F);
            BClientes.Location = new Point(13, 131);
            BClientes.Margin = new Padding(3, 4, 3, 4);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(129, 113);
            BClientes.TabIndex = 5;
            BClientes.Text = "Clientes";
            BClientes.TextAlign = ContentAlignment.BottomCenter;
            BClientes.UseVisualStyleBackColor = false;
            BClientes.Click += BClientes_Click;
            // 
            // BEmpleados
            // 
            BEmpleados.BackColor = Color.Plum;
            BEmpleados.Font = new Font("Segoe UI", 14.25F);
            BEmpleados.Location = new Point(13, 485);
            BEmpleados.Margin = new Padding(3, 4, 3, 4);
            BEmpleados.Name = "BEmpleados";
            BEmpleados.Size = new Size(129, 107);
            BEmpleados.TabIndex = 6;
            BEmpleados.Text = "Empleados";
            BEmpleados.TextAlign = ContentAlignment.BottomCenter;
            BEmpleados.UseVisualStyleBackColor = false;
            BEmpleados.Click += BEmpleados_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(PBEmpleado);
            panel1.Controls.Add(PBBackUp);
            panel1.Controls.Add(BBackUp);
            panel1.Controls.Add(PBProducto);
            panel1.Controls.Add(PBCliente);
            panel1.Controls.Add(PBVenta);
            panel1.Controls.Add(PBReporte);
            panel1.Controls.Add(PBSalir);
            panel1.Controls.Add(PBUsuario);
            panel1.Controls.Add(BUsuario);
            panel1.Controls.Add(BEmpleados);
            panel1.Controls.Add(BReportes);
            panel1.Controls.Add(BProductos);
            panel1.Controls.Add(BVentas);
            panel1.Controls.Add(BClientes);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 943);
            panel1.TabIndex = 8;
            // 
            // PBEmpleado
            // 
            PBEmpleado.BackColor = Color.Plum;
            PBEmpleado.Image = Properties.Resources._554795;
            PBEmpleado.Location = new Point(46, 497);
            PBEmpleado.Margin = new Padding(3, 4, 3, 4);
            PBEmpleado.Name = "PBEmpleado";
            PBEmpleado.Size = new Size(63, 57);
            PBEmpleado.SizeMode = PictureBoxSizeMode.StretchImage;
            PBEmpleado.TabIndex = 18;
            PBEmpleado.TabStop = false;
            PBEmpleado.Click += PBEmpleado_Click;
            // 
            // PBBackUp
            // 
            PBBackUp.BackColor = Color.Plum;
            PBBackUp.Image = Properties.Resources._5322156;
            PBBackUp.Location = new Point(46, 735);
            PBBackUp.Margin = new Padding(3, 4, 3, 4);
            PBBackUp.Name = "PBBackUp";
            PBBackUp.Size = new Size(63, 57);
            PBBackUp.SizeMode = PictureBoxSizeMode.StretchImage;
            PBBackUp.TabIndex = 19;
            PBBackUp.TabStop = false;
            PBBackUp.Click += PBBackup_Click;
            // 
            // BBackUp
            // 
            BBackUp.BackColor = Color.Plum;
            BBackUp.Font = new Font("Segoe UI", 14.25F);
            BBackUp.Location = new Point(13, 721);
            BBackUp.Margin = new Padding(3, 4, 3, 4);
            BBackUp.Name = "BBackUp";
            BBackUp.Size = new Size(129, 113);
            BBackUp.TabIndex = 13;
            BBackUp.Text = "Backup";
            BBackUp.TextAlign = ContentAlignment.BottomCenter;
            BBackUp.UseVisualStyleBackColor = false;
            BBackUp.Click += BBackup_Click;
            // 
            // PBProducto
            // 
            PBProducto.BackColor = Color.Plum;
            PBProducto.Image = Properties.Resources._11458663;
            PBProducto.Location = new Point(46, 615);
            PBProducto.Margin = new Padding(3, 4, 3, 4);
            PBProducto.Name = "PBProducto";
            PBProducto.Size = new Size(63, 57);
            PBProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            PBProducto.TabIndex = 17;
            PBProducto.TabStop = false;
            PBProducto.Click += PBProducto_Click;
            // 
            // PBCliente
            // 
            PBCliente.BackColor = Color.Plum;
            PBCliente.Image = Properties.Resources._5c83929a6b79026e0f85cd9a021c9dcb;
            PBCliente.Location = new Point(46, 143);
            PBCliente.Margin = new Padding(3, 4, 3, 4);
            PBCliente.Name = "PBCliente";
            PBCliente.Size = new Size(63, 57);
            PBCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            PBCliente.TabIndex = 16;
            PBCliente.TabStop = false;
            PBCliente.Click += PBCliente_Click;
            // 
            // PBVenta
            // 
            PBVenta.BackColor = Color.Plum;
            PBVenta.Image = Properties.Resources._6633320;
            PBVenta.Location = new Point(46, 264);
            PBVenta.Margin = new Padding(3, 4, 3, 4);
            PBVenta.Name = "PBVenta";
            PBVenta.Size = new Size(63, 57);
            PBVenta.SizeMode = PictureBoxSizeMode.StretchImage;
            PBVenta.TabIndex = 15;
            PBVenta.TabStop = false;
            PBVenta.Click += PBVenta_Click;
            // 
            // PBReporte
            // 
            PBReporte.BackColor = Color.Plum;
            PBReporte.BackgroundImage = Properties.Resources.staff;
            PBReporte.BackgroundImageLayout = ImageLayout.Zoom;
            PBReporte.Image = Properties.Resources._5674015;
            PBReporte.Location = new Point(46, 383);
            PBReporte.Margin = new Padding(3, 4, 3, 4);
            PBReporte.Name = "PBReporte";
            PBReporte.Size = new Size(63, 59);
            PBReporte.SizeMode = PictureBoxSizeMode.StretchImage;
            PBReporte.TabIndex = 14;
            PBReporte.TabStop = false;
            PBReporte.Click += PBReporte_Click;
            // 
            // PBSalir
            // 
            PBSalir.BackColor = Color.Transparent;
            PBSalir.BackgroundImage = Properties.Resources.left_arrow;
            PBSalir.BackgroundImageLayout = ImageLayout.Zoom;
            PBSalir.Location = new Point(13, 865);
            PBSalir.Margin = new Padding(3, 4, 3, 4);
            PBSalir.Name = "PBSalir";
            PBSalir.Size = new Size(129, 61);
            PBSalir.TabIndex = 10;
            PBSalir.TabStop = false;
            PBSalir.Click += PBSalir_Click_1;
            // 
            // PBUsuario
            // 
            PBUsuario.BackColor = Color.Plum;
            PBUsuario.BackgroundImage = Properties.Resources.profile;
            PBUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            PBUsuario.Location = new Point(46, 28);
            PBUsuario.Margin = new Padding(3, 4, 3, 4);
            PBUsuario.Name = "PBUsuario";
            PBUsuario.Size = new Size(63, 57);
            PBUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            PBUsuario.TabIndex = 9;
            PBUsuario.TabStop = false;
            PBUsuario.Click += PBUsuario_Click;
            // 
            // BReportes
            // 
            BReportes.BackColor = Color.Plum;
            BReportes.Font = new Font("Segoe UI", 14.25F);
            BReportes.Location = new Point(13, 371);
            BReportes.Margin = new Padding(3, 4, 3, 4);
            BReportes.Name = "BReportes";
            BReportes.Size = new Size(129, 107);
            BReportes.TabIndex = 3;
            BReportes.Text = "Reportes";
            BReportes.TextAlign = ContentAlignment.BottomCenter;
            BReportes.UseVisualStyleBackColor = false;
            BReportes.Click += BReportes_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(pictureBox8);
            panelContenedor.Location = new Point(150, 0);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1014, 943);
            panelContenedor.TabIndex = 19;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.logo;
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(1014, 943);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 943);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formPrincipal";
            Text = "Menú";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBEmpleado).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBBackUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBReporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBUsuario).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BUsuario;
        private Button BVentas;
        private Button BProductos;
        private Button BClientes;
        private Button BEmpleados;
        private Panel panel1;
        private PictureBox PBUsuario;
        private Button BReportes;
        private PictureBox PBSalir;
        private Button BBackUp;
        private PictureBox pictureBox8;
        private PictureBox PBReporte;
        private PictureBox PBProducto;
        private PictureBox PBCliente;
        private PictureBox PBVenta;
        private PictureBox PBEmpleado;
        private Panel panelContenedor;
        private PictureBox PBBackUp;
    }
}