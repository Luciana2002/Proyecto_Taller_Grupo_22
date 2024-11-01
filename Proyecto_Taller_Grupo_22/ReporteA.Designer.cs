namespace Proyecto_Taller_Grupo_22
{
    partial class ReporteA
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
            label3 = new Label();
            btnReporteProductos = new Button();
            btnReporteBackups = new Button();
            btnReporteUsuarios = new Button();
            btnReporteClientes = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dgvReporte = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.Location = new Point(362, 194);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 18);
            label3.TabIndex = 88;
            label3.Text = "Generar Reporte por:";
            // 
            // btnReporteProductos
            // 
            btnReporteProductos.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnReporteProductos.Location = new Point(442, 224);
            btnReporteProductos.Margin = new Padding(3, 2, 3, 2);
            btnReporteProductos.Name = "btnReporteProductos";
            btnReporteProductos.Size = new Size(120, 56);
            btnReporteProductos.TabIndex = 87;
            btnReporteProductos.Text = "Productos";
            btnReporteProductos.UseVisualStyleBackColor = true;
            btnReporteProductos.Click += btnReporteProductos_Click;
            // 
            // btnReporteBackups
            // 
            btnReporteBackups.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnReporteBackups.Location = new Point(567, 224);
            btnReporteBackups.Margin = new Padding(3, 2, 3, 2);
            btnReporteBackups.Name = "btnReporteBackups";
            btnReporteBackups.Size = new Size(120, 56);
            btnReporteBackups.TabIndex = 86;
            btnReporteBackups.Text = "Registros Backup";
            btnReporteBackups.UseVisualStyleBackColor = true;
            btnReporteBackups.Click += btnReporteBackups_Click;
            // 
            // btnReporteUsuarios
            // 
            btnReporteUsuarios.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnReporteUsuarios.Location = new Point(192, 224);
            btnReporteUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnReporteUsuarios.Name = "btnReporteUsuarios";
            btnReporteUsuarios.Size = new Size(120, 56);
            btnReporteUsuarios.TabIndex = 84;
            btnReporteUsuarios.Text = "Usuarios";
            btnReporteUsuarios.UseVisualStyleBackColor = true;
            btnReporteUsuarios.Click += btnReporteUsuarios_Click;
            // 
            // btnReporteClientes
            // 
            btnReporteClientes.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnReporteClientes.Location = new Point(317, 224);
            btnReporteClientes.Margin = new Padding(3, 2, 3, 2);
            btnReporteClientes.Name = "btnReporteClientes";
            btnReporteClientes.Size = new Size(120, 56);
            btnReporteClientes.TabIndex = 94;
            btnReporteClientes.Text = "Clientes";
            btnReporteClientes.UseVisualStyleBackColor = true;
            btnReporteClientes.Click += btnReporteClientes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpFechaFin);
            panel1.Controls.Add(dtpFechaInicio);
            panel1.Location = new Point(192, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 100);
            panel1.TabIndex = 97;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(353, 19);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 4;
            label5.Text = "Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 19);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 3;
            label4.Text = "Desde:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(311, 46);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(144, 22);
            dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(37, 46);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(144, 22);
            dtpFechaInicio.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(378, 57);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 96;
            label2.Text = "Elegir fechas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 16);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 95;
            label1.Text = "Reportes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(23, 300);
            dgvReporte.Margin = new Padding(3, 2, 3, 2);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(835, 388);
            dgvReporte.TabIndex = 98;
            // 
            // ReporteA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(897, 728);
            Controls.Add(dgvReporte);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReporteClientes);
            Controls.Add(label3);
            Controls.Add(btnReporteProductos);
            Controls.Add(btnReporteBackups);
            Controls.Add(btnReporteUsuarios);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReporteA";
            Text = "Reporte Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button btnReporteProductos;
        private Button btnReporteBackups;
        private Button btnReporteUsuarios;
        private Button btnReporteClientes;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label label2;
        private Label label1;
        private DataGridView dgvReporte;
    }
}