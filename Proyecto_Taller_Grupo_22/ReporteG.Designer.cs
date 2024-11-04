namespace Proyecto_Taller_Grupo_22
{
    partial class ReporteG
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
            dgvReporte = new DataGridView();
            btnTodasVentasVendedor = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            BBuscar = new Button();
            TEmpleadoNombre = new TextBox();
            TEmpleadoID = new TextBox();
            label6 = new Label();
            btnTodasVentas = new Button();
            btnProductosMasVendidos = new Button();
            btnMayorRecaudacion = new Button();
            btndescargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(29, 526);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(958, 392);
            dgvReporte.TabIndex = 116;
            // 
            // btnTodasVentasVendedor
            // 
            btnTodasVentasVendedor.Font = new Font("Microsoft Sans Serif", 12F);
            btnTodasVentasVendedor.Location = new Point(626, 396);
            btnTodasVentasVendedor.Name = "btnTodasVentasVendedor";
            btnTodasVentasVendedor.Size = new Size(164, 34);
            btnTodasVentasVendedor.TabIndex = 115;
            btnTodasVentasVendedor.Text = "Reporte Ventas";
            btnTodasVentasVendedor.UseVisualStyleBackColor = true;
            btnTodasVentasVendedor.Click += btnTodasVentasVendedor_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpFechaFin);
            panel1.Controls.Add(dtpFechaInicio);
            panel1.Location = new Point(223, 112);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 133);
            panel1.TabIndex = 114;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(403, 25);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 29);
            label5.TabIndex = 4;
            label5.Text = "Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 25);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 29);
            label4.TabIndex = 3;
            label4.Text = "Desde:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(355, 61);
            dtpFechaFin.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(164, 26);
            dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(42, 61);
            dtpFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(164, 26);
            dtpFechaInicio.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(435, 75);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 113;
            label2.Text = "Elegir fechas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(445, 20);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 112;
            label1.Text = "Reportes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.Location = new Point(417, 258);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 24);
            label3.TabIndex = 111;
            label3.Text = "Generar Reporte por:";
            // 
            // BBuscar
            // 
            BBuscar.Font = new Font("Microsoft Sans Serif", 12F);
            BBuscar.Location = new Point(522, 396);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(98, 34);
            BBuscar.TabIndex = 110;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscarE_Click;
            // 
            // TEmpleadoNombre
            // 
            TEmpleadoNombre.Font = new Font("Microsoft Sans Serif", 12F);
            TEmpleadoNombre.Location = new Point(296, 398);
            TEmpleadoNombre.Name = "TEmpleadoNombre";
            TEmpleadoNombre.Size = new Size(220, 30);
            TEmpleadoNombre.TabIndex = 109;
            // 
            // TEmpleadoID
            // 
            TEmpleadoID.Font = new Font("Microsoft Sans Serif", 12F);
            TEmpleadoID.Location = new Point(223, 398);
            TEmpleadoID.Name = "TEmpleadoID";
            TEmpleadoID.Size = new Size(67, 30);
            TEmpleadoID.TabIndex = 108;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(223, 367);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 107;
            label6.Text = "Vendedor:";
            // 
            // btnTodasVentas
            // 
            btnTodasVentas.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnTodasVentas.Location = new Point(583, 297);
            btnTodasVentas.Name = "btnTodasVentas";
            btnTodasVentas.Size = new Size(137, 45);
            btnTodasVentas.TabIndex = 106;
            btnTodasVentas.Text = "Total ventas";
            btnTodasVentas.UseVisualStyleBackColor = true;
            btnTodasVentas.Click += btnTodasVentas_Click;
            // 
            // btnProductosMasVendidos
            // 
            btnProductosMasVendidos.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnProductosMasVendidos.Location = new Point(440, 297);
            btnProductosMasVendidos.Name = "btnProductosMasVendidos";
            btnProductosMasVendidos.Size = new Size(137, 45);
            btnProductosMasVendidos.TabIndex = 105;
            btnProductosMasVendidos.Text = "Más vendidos";
            btnProductosMasVendidos.UseVisualStyleBackColor = true;
            btnProductosMasVendidos.Click += btnProductosMasVendidos_Click;
            // 
            // btnMayorRecaudacion
            // 
            btnMayorRecaudacion.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnMayorRecaudacion.Location = new Point(297, 297);
            btnMayorRecaudacion.Name = "btnMayorRecaudacion";
            btnMayorRecaudacion.Size = new Size(137, 45);
            btnMayorRecaudacion.TabIndex = 104;
            btnMayorRecaudacion.Text = "Recaudación";
            btnMayorRecaudacion.UseVisualStyleBackColor = true;
            btnMayorRecaudacion.Click += btnMayorRecaudacion_Click;
            // 
            // btndescargar
            // 
            btndescargar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btndescargar.Location = new Point(417, 464);
            btndescargar.Name = "btndescargar";
            btndescargar.Size = new Size(189, 41);
            btndescargar.TabIndex = 117;
            btndescargar.Text = "Imprimir";
            btndescargar.UseVisualStyleBackColor = true;
            btndescargar.Click += btndescargar_Click;
            // 
            // ReporteG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1018, 739);
            Controls.Add(btndescargar);
            Controls.Add(dgvReporte);
            Controls.Add(btnTodasVentasVendedor);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BBuscar);
            Controls.Add(TEmpleadoNombre);
            Controls.Add(TEmpleadoID);
            Controls.Add(label6);
            Controls.Add(btnTodasVentas);
            Controls.Add(btnProductosMasVendidos);
            Controls.Add(btnMayorRecaudacion);
            Name = "ReporteG";
            Text = "ReporteG";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReporte;
        private Button btnTodasVentasVendedor;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button BBuscar;
        private TextBox TEmpleadoNombre;
        private TextBox TEmpleadoID;
        private Label label6;
        private Button btnTodasVentas;
        private Button btnProductosMasVendidos;
        private Button btnMayorRecaudacion;
        private Button btndescargar;
    }
}
