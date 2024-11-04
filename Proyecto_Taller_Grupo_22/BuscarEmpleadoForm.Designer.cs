namespace Proyecto_Taller_Grupo_22
{
    partial class BuscarEmpleadoForm
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
            BLimpiar = new Button();
            CBFiltro = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            BBuscar = new Button();
            TBuscarEmpleado = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BLimpiar
            // 
            BLimpiar.Location = new Point(584, 85);
            BLimpiar.Margin = new Padding(3, 4, 3, 4);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(112, 37);
            BLimpiar.TabIndex = 13;
            BLimpiar.Text = "Limpiar Filtro";
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // CBFiltro
            // 
            CBFiltro.FormattingEnabled = true;
            CBFiltro.Location = new Point(111, 91);
            CBFiltro.Margin = new Padding(3, 4, 3, 4);
            CBFiltro.Name = "CBFiltro";
            CBFiltro.Size = new Size(138, 28);
            CBFiltro.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 95);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 11;
            label2.Text = "Filtrar por:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 155);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(865, 429);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(468, 85);
            BBuscar.Margin = new Padding(3, 4, 3, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(110, 37);
            BBuscar.TabIndex = 9;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBuscarEmpleado
            // 
            TBuscarEmpleado.Location = new Point(256, 91);
            TBuscarEmpleado.Margin = new Padding(3, 4, 3, 4);
            TBuscarEmpleado.Name = "TBuscarEmpleado";
            TBuscarEmpleado.Size = new Size(204, 27);
            TBuscarEmpleado.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(275, 31);
            label1.TabIndex = 7;
            label1.Text = "Listado de Empleados";
            // 
            // BuscarEmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(933, 612);
            Controls.Add(BLimpiar);
            Controls.Add(CBFiltro);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(BBuscar);
            Controls.Add(TBuscarEmpleado);
            Controls.Add(label1);
            Name = "BuscarEmpleadoForm";
            Text = "BuscarEmpleadoForm";
            Load += BuscarEmpleadoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BLimpiar;
        private ComboBox CBFiltro;
        private Label label2;
        private DataGridView dataGridView1;
        private Button BBuscar;
        private TextBox TBuscarEmpleado;
        private Label label1;
    }
}