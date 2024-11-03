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
            label1 = new Label();
            dgvReporte = new DataGridView();
            btndescargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.Location = new Point(414, 90);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 24);
            label3.TabIndex = 88;
            label3.Text = "Generar Reporte por:";
            // 
            // btnReporteProductos
            // 
            btnReporteProductos.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnReporteProductos.Location = new Point(505, 130);
            btnReporteProductos.Name = "btnReporteProductos";
            btnReporteProductos.Size = new Size(137, 75);
            btnReporteProductos.TabIndex = 87;
            btnReporteProductos.Text = "Productos";
            btnReporteProductos.UseVisualStyleBackColor = true;
            btnReporteProductos.Click += btnReporteProductos_Click;
            // 
            // btnReporteBackups
            // 
            btnReporteBackups.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnReporteBackups.Location = new Point(648, 130);
            btnReporteBackups.Name = "btnReporteBackups";
            btnReporteBackups.Size = new Size(137, 75);
            btnReporteBackups.TabIndex = 86;
            btnReporteBackups.Text = "Registros Backup";
            btnReporteBackups.UseVisualStyleBackColor = true;
            btnReporteBackups.Click += btnReporteBackups_Click;
            // 
            // btnReporteUsuarios
            // 
            btnReporteUsuarios.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnReporteUsuarios.Location = new Point(219, 130);
            btnReporteUsuarios.Name = "btnReporteUsuarios";
            btnReporteUsuarios.Size = new Size(137, 75);
            btnReporteUsuarios.TabIndex = 84;
            btnReporteUsuarios.Text = "Usuarios";
            btnReporteUsuarios.UseVisualStyleBackColor = true;
            btnReporteUsuarios.Click += btnReporteUsuarios_Click;
            // 
            // btnReporteClientes
            // 
            btnReporteClientes.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnReporteClientes.Location = new Point(362, 130);
            btnReporteClientes.Name = "btnReporteClientes";
            btnReporteClientes.Size = new Size(137, 75);
            btnReporteClientes.TabIndex = 94;
            btnReporteClientes.Text = "Clientes";
            btnReporteClientes.UseVisualStyleBackColor = true;
            btnReporteClientes.Click += btnReporteClientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 21);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 95;
            label1.Text = "Reportes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(26, 333);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(954, 584);
            dgvReporte.TabIndex = 98;
            // 
            // btndescargar
            // 
            btndescargar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btndescargar.Location = new Point(414, 247);
            btndescargar.Name = "btndescargar";
            btndescargar.Size = new Size(189, 41);
            btndescargar.TabIndex = 99;
            btndescargar.Text = "Imprimir";
            btndescargar.UseVisualStyleBackColor = true;
            btndescargar.Click += btndescargar_Click;
            // 
            // ReporteA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1025, 971);
            Controls.Add(btndescargar);
            Controls.Add(dgvReporte);
            Controls.Add(label1);
            Controls.Add(btnReporteClientes);
            Controls.Add(label3);
            Controls.Add(btnReporteProductos);
            Controls.Add(btnReporteBackups);
            Controls.Add(btnReporteUsuarios);
            Name = "ReporteA";
            Text = "Reporte Administrador";
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
        private Button btndescargar;
    }
}