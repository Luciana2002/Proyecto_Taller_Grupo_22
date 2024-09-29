namespace Proyecto_Taller_Grupo_22
{
    partial class Venta
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
            TBuscarVenta = new TextBox();
            label1 = new Label();
            BAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BLimpiar
            // 
            BLimpiar.Font = new Font("Microsoft Sans Serif", 12F);
            BLimpiar.Location = new Point(534, 71);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(98, 27);
            BLimpiar.TabIndex = 20;
            BLimpiar.Text = "Limpiar Filtro";
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // CBFiltro
            // 
            CBFiltro.Font = new Font("Microsoft Sans Serif", 12F);
            CBFiltro.FormattingEnabled = true;
            CBFiltro.Location = new Point(120, 70);
            CBFiltro.Name = "CBFiltro";
            CBFiltro.Size = new Size(121, 28);
            CBFiltro.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(34, 73);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 18;
            label2.Text = "Filtrar por:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(804, 557);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // BBuscar
            // 
            BBuscar.Font = new Font("Microsoft Sans Serif", 12F);
            BBuscar.Location = new Point(432, 70);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(96, 28);
            BBuscar.TabIndex = 16;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBuscarVenta
            // 
            TBuscarVenta.Font = new Font("Microsoft Sans Serif", 12F);
            TBuscarVenta.Location = new Point(247, 71);
            TBuscarVenta.Name = "TBuscarVenta";
            TBuscarVenta.Size = new Size(179, 26);
            TBuscarVenta.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 21);
            label1.Name = "label1";
            label1.Size = new Size(176, 24);
            label1.TabIndex = 14;
            label1.Text = "Listado de Ventas";
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Microsoft Sans Serif", 12F);
            BAgregar.Location = new Point(705, 40);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(133, 58);
            BAgregar.TabIndex = 54;
            BAgregar.Text = "Nueva Venta";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(880, 716);
            Controls.Add(BAgregar);
            Controls.Add(BLimpiar);
            Controls.Add(CBFiltro);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(BBuscar);
            Controls.Add(TBuscarVenta);
            Controls.Add(label1);
            Name = "Venta";
            Text = "Form2";
            Load += Venta_Load;
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
        private TextBox TBuscarVenta;
        private Label label1;
        private Button BAgregar;
    }
}