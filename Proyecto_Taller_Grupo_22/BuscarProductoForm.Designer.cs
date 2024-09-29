namespace Proyecto_Taller_Grupo_22
{
    partial class BuscarProductoForm
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
            TBuscarProducto = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BLimpiar
            // 
            BLimpiar.Location = new Point(503, 62);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(98, 27);
            BLimpiar.TabIndex = 13;
            BLimpiar.Text = "Limpiar Filtro";
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // CBFiltro
            // 
            CBFiltro.FormattingEnabled = true;
            CBFiltro.Location = new Point(89, 65);
            CBFiltro.Name = "CBFiltro";
            CBFiltro.Size = new Size(121, 23);
            CBFiltro.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 68);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 11;
            label2.Text = "Filtrar por:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(757, 322);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(401, 61);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(96, 28);
            BBuscar.TabIndex = 9;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBuscarProducto
            // 
            TBuscarProducto.Location = new Point(216, 65);
            TBuscarProducto.Name = "TBuscarProducto";
            TBuscarProducto.Size = new Size(179, 23);
            TBuscarProducto.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 7;
            label1.Text = "Listado de Productos";
            // 
            // BuscarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(BLimpiar);
            Controls.Add(CBFiltro);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(BBuscar);
            Controls.Add(TBuscarProducto);
            Controls.Add(label1);
            Name = "BuscarProductoForm";
            Text = "Buscar Producto";
            Load += BuscarProductoForm_Load;
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
        private TextBox TBuscarProducto;
        private Label label1;
    }
}