namespace Proyecto_Taller_Grupo_22
{
    partial class BuscarClienteForm
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
            label1 = new Label();
            TBuscarCliente = new TextBox();
            BBuscar = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            CBFiltro = new ComboBox();
            BLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 0;
            label1.Text = "Listado de Clientes";
            // 
            // TBuscarCliente
            // 
            TBuscarCliente.Location = new Point(225, 68);
            TBuscarCliente.Name = "TBuscarCliente";
            TBuscarCliente.Size = new Size(179, 23);
            TBuscarCliente.TabIndex = 1;
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(410, 64);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(96, 28);
            BBuscar.TabIndex = 2;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(757, 322);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 71);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Filtrar por:";
            // 
            // CBFiltro
            // 
            CBFiltro.FormattingEnabled = true;
            CBFiltro.Location = new Point(98, 68);
            CBFiltro.Name = "CBFiltro";
            CBFiltro.Size = new Size(121, 23);
            CBFiltro.TabIndex = 5;
            // 
            // BLimpiar
            // 
            BLimpiar.Location = new Point(512, 64);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(98, 28);
            BLimpiar.TabIndex = 6;
            BLimpiar.Text = "Limpiar Filtro";
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // BuscarClienteForm
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
            Controls.Add(TBuscarCliente);
            Controls.Add(label1);
            Name = "BuscarClienteForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Cliente";
            Load += BuscarClienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBuscarCliente;
        private Button BBuscar;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox CBFiltro;
        private Button BLimpiar;
    }
}