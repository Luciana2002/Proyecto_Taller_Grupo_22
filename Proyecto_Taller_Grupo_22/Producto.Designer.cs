namespace Proyecto_Taller_Grupo_22
{
    partial class Producto
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
            TPVenta = new TextBox();
            TPCosto = new TextBox();
            CBCategoria = new ComboBox();
            TStock = new TextBox();
            TNombreP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BEliminadosP = new Button();
            BDisponiblesP = new Button();
            BAceptar = new Button();
            BLimpiar = new Button();
            BAgregar = new Button();
            BTodos = new Button();
            btnChangeStatus = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TPVenta
            // 
            TPVenta.Font = new Font("Segoe UI", 12F);
            TPVenta.Location = new Point(534, 101);
            TPVenta.Name = "TPVenta";
            TPVenta.Size = new Size(81, 29);
            TPVenta.TabIndex = 24;
            // 
            // TPCosto
            // 
            TPCosto.Font = new Font("Segoe UI", 12F);
            TPCosto.Location = new Point(534, 65);
            TPCosto.Name = "TPCosto";
            TPCosto.Size = new Size(81, 29);
            TPCosto.TabIndex = 23;
            // 
            // CBCategoria
            // 
            CBCategoria.Font = new Font("Segoe UI", 12F);
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(177, 101);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(185, 29);
            CBCategoria.TabIndex = 22;
            // 
            // TStock
            // 
            TStock.Font = new Font("Segoe UI", 12F);
            TStock.Location = new Point(177, 137);
            TStock.Name = "TStock";
            TStock.Size = new Size(81, 29);
            TStock.TabIndex = 21;
            // 
            // TNombreP
            // 
            TNombreP.Font = new Font("Segoe UI", 12F);
            TNombreP.Location = new Point(177, 65);
            TNombreP.Name = "TNombreP";
            TNombreP.Size = new Size(185, 29);
            TNombreP.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(419, 99);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 19;
            label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(418, 69);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 18;
            label5.Text = "Precio Costo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(105, 140);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 17;
            label4.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(75, 104);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 16;
            label3.Text = "Categoría:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 15;
            label2.Text = "Nombre producto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 14;
            label1.Text = "Productos";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnChangeStatus });
            dataGridView1.Location = new Point(17, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(850, 453);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // BEliminadosP
            // 
            BEliminadosP.Font = new Font("Microsoft Sans Serif", 12F);
            BEliminadosP.Location = new Point(245, 197);
            BEliminadosP.Name = "BEliminadosP";
            BEliminadosP.Size = new Size(106, 35);
            BEliminadosP.TabIndex = 54;
            BEliminadosP.Text = "Eliminados";
            BEliminadosP.UseVisualStyleBackColor = true;
            BEliminadosP.Click += BEliminados_Click;
            // 
            // BDisponiblesP
            // 
            BDisponiblesP.Font = new Font("Microsoft Sans Serif", 12F);
            BDisponiblesP.Location = new Point(133, 197);
            BDisponiblesP.Name = "BDisponiblesP";
            BDisponiblesP.Size = new Size(106, 35);
            BDisponiblesP.TabIndex = 53;
            BDisponiblesP.Text = "Disponibles";
            BDisponiblesP.UseVisualStyleBackColor = true;
            BDisponiblesP.Click += BDisponibles_Click;
            // 
            // BAceptar
            // 
            BAceptar.Font = new Font("Microsoft Sans Serif", 12F);
            BAceptar.Location = new Point(687, 197);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(180, 35);
            BAceptar.TabIndex = 62;
            BAceptar.Text = "Guardar Cambios";
            BAceptar.UseVisualStyleBackColor = true;
            BAceptar.Click += BAceptar_Click;
            // 
            // BLimpiar
            // 
            BLimpiar.Font = new Font("Microsoft Sans Serif", 12F);
            BLimpiar.Location = new Point(734, 109);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(133, 61);
            BLimpiar.TabIndex = 61;
            BLimpiar.Text = "Limpiar";
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Microsoft Sans Serif", 12F);
            BAgregar.Location = new Point(734, 33);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(133, 58);
            BAgregar.TabIndex = 60;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BTodos
            // 
            BTodos.Font = new Font("Microsoft Sans Serif", 12F);
            BTodos.Location = new Point(21, 197);
            BTodos.Name = "BTodos";
            BTodos.Size = new Size(106, 35);
            BTodos.TabIndex = 63;
            BTodos.Text = "Todos";
            BTodos.UseVisualStyleBackColor = true;
            BTodos.Click += BTodos_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnChangeStatus.HeaderText = "Acción";
            btnChangeStatus.Image = Properties.Resources.Altas_y_bajas;
            btnChangeStatus.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnChangeStatus.MinimumWidth = 6;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Width = 60;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(879, 715);
            Controls.Add(BTodos);
            Controls.Add(BAceptar);
            Controls.Add(BLimpiar);
            Controls.Add(BAgregar);
            Controls.Add(BEliminadosP);
            Controls.Add(BDisponiblesP);
            Controls.Add(TPVenta);
            Controls.Add(TPCosto);
            Controls.Add(CBCategoria);
            Controls.Add(TStock);
            Controls.Add(TNombreP);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Producto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Productos";
            Load += Producto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TPVenta;
        private TextBox TPCosto;
        private ComboBox CBCategoria;
        private TextBox TStock;
        private TextBox TNombreP;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button BEliminadosP;
        private Button BDisponiblesP;
        private Button BAceptar;
        private Button BLimpiar;
        private Button BAgregar;
        private Button BTodos;
        private DataGridViewImageColumn btnChangeStatus;
    }
}
