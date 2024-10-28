namespace Proyecto_Taller_Grupo_22
{
    partial class ReporteE
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            GenerarR = new Button();
            label2 = new Label();
            label1 = new Label();
            dgvproductos = new DataGridView();
            btndescargar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpFechaFin);
            panel1.Controls.Add(dtpFechaInicio);
            panel1.Location = new Point(213, 115);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 133);
            panel1.TabIndex = 89;
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
            // GenerarR
            // 
            GenerarR.Font = new Font("Microsoft Sans Serif", 11.25F);
            GenerarR.Location = new Point(302, 272);
            GenerarR.Margin = new Padding(3, 4, 3, 4);
            GenerarR.Name = "GenerarR";
            GenerarR.Size = new Size(195, 49);
            GenerarR.TabIndex = 86;
            GenerarR.Text = "Generar Reporte";
            GenerarR.UseVisualStyleBackColor = true;
            GenerarR.Click += GenerarR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 78);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 85;
            label2.Text = "Elegir fechas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(435, 23);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 83;
            label1.Text = "Reportes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvproductos
            // 
            dgvproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvproductos.Location = new Point(26, 347);
            dgvproductos.Name = "dgvproductos";
            dgvproductos.RowHeadersWidth = 51;
            dgvproductos.Size = new Size(954, 510);
            dgvproductos.TabIndex = 90;
            // 
            // btndescargar
            // 
            btndescargar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btndescargar.Location = new Point(503, 272);
            btndescargar.Margin = new Padding(3, 4, 3, 4);
            btndescargar.Name = "btndescargar";
            btndescargar.Size = new Size(195, 49);
            btndescargar.TabIndex = 91;
            btndescargar.Text = "Imprimir";
            btndescargar.UseVisualStyleBackColor = true;
            btndescargar.Click += btndescargar_Click;
            // 
            // ReporteE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1015, 875);
            Controls.Add(btndescargar);
            Controls.Add(dgvproductos);
            Controls.Add(panel1);
            Controls.Add(GenerarR);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReporteE";
            Text = "ReporteE";
            Load += ReporteE_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label label3;
        private Button button3;
        private Button GenerarR;
        private Label label2;
        private Button button1;
        private Label label1;
        private DataGridView dgvproductos;
        private Button btndescargar;
    }
}