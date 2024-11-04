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
            TClienteNombre = new TextBox();
            dataGridView2 = new DataGridView();
            BAgregar = new Button();
            numericUpDown1 = new NumericUpDown();
            TSubtotal = new TextBox();
            label9 = new Label();
            TStock = new TextBox();
            TPrecioV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            BBuscarP = new Button();
            TProductoNombre = new TextBox();
            TProductoID = new TextBox();
            label4 = new Label();
            BuscarC = new Button();
            TClienteID = new TextBox();
            label3 = new Label();
            TVendedorNombre = new TextBox();
            TVendedorID = new TextBox();
            label8 = new Label();
            label10 = new Label();
            BConfirmar = new Button();
            TTotal = new TextBox();
            label11 = new Label();
            CBTipoV = new ComboBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // BLimpiar
            // 
            BLimpiar.Font = new Font("Microsoft Sans Serif", 12F);
            BLimpiar.Location = new Point(610, 636);
            BLimpiar.Margin = new Padding(3, 4, 3, 4);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(112, 36);
            BLimpiar.TabIndex = 20;
            BLimpiar.Text = "Limpiar Filtro";
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // CBFiltro
            // 
            CBFiltro.Font = new Font("Microsoft Sans Serif", 12F);
            CBFiltro.FormattingEnabled = true;
            CBFiltro.Location = new Point(137, 634);
            CBFiltro.Margin = new Padding(3, 4, 3, 4);
            CBFiltro.Name = "CBFiltro";
            CBFiltro.Size = new Size(138, 33);
            CBFiltro.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(39, 638);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 18;
            label2.Text = "Filtrar por:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 302);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 267);
            dataGridView1.TabIndex = 123;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BBuscar
            // 
            BBuscar.Font = new Font("Microsoft Sans Serif", 12F);
            BBuscar.Location = new Point(494, 634);
            BBuscar.Margin = new Padding(3, 4, 3, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(110, 37);
            BBuscar.TabIndex = 16;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBuscarVenta
            // 
            TBuscarVenta.Font = new Font("Microsoft Sans Serif", 12F);
            TBuscarVenta.Location = new Point(282, 636);
            TBuscarVenta.Margin = new Padding(3, 4, 3, 4);
            TBuscarVenta.Name = "TBuscarVenta";
            TBuscarVenta.Size = new Size(204, 30);
            TBuscarVenta.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 584);
            label1.Name = "label1";
            label1.Size = new Size(221, 29);
            label1.TabIndex = 14;
            label1.Text = "Listado de Ventas";
            // 
            // TClienteNombre
            // 
            TClienteNombre.Font = new Font("Microsoft Sans Serif", 12F);
            TClienteNombre.Location = new Point(121, 93);
            TClienteNombre.Margin = new Padding(3, 4, 3, 4);
            TClienteNombre.Name = "TClienteNombre";
            TClienteNombre.Size = new Size(234, 30);
            TClienteNombre.TabIndex = 124;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(39, 679);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(919, 243);
            dataGridView2.TabIndex = 17;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAgregar.Location = new Point(708, 236);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(122, 59);
            BAgregar.TabIndex = 122;
            BAgregar.Text = "Agregar Producto";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(165, 265);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(119, 27);
            numericUpDown1.TabIndex = 121;
            // 
            // TSubtotal
            // 
            TSubtotal.Font = new Font("Microsoft Sans Serif", 12F);
            TSubtotal.Location = new Point(448, 265);
            TSubtotal.Margin = new Padding(3, 4, 3, 4);
            TSubtotal.Name = "TSubtotal";
            TSubtotal.Size = new Size(152, 30);
            TSubtotal.TabIndex = 120;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(448, 236);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 119;
            label9.Text = "Subtotal:";
            // 
            // TStock
            // 
            TStock.Font = new Font("Microsoft Sans Serif", 12F);
            TStock.Location = new Point(39, 265);
            TStock.Margin = new Padding(3, 4, 3, 4);
            TStock.Name = "TStock";
            TStock.Size = new Size(118, 30);
            TStock.TabIndex = 118;
            // 
            // TPrecioV
            // 
            TPrecioV.Font = new Font("Microsoft Sans Serif", 12F);
            TPrecioV.Location = new Point(290, 265);
            TPrecioV.Margin = new Padding(3, 4, 3, 4);
            TPrecioV.Name = "TPrecioV";
            TPrecioV.Size = new Size(152, 30);
            TPrecioV.TabIndex = 117;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(165, 236);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 116;
            label7.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(290, 236);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 115;
            label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(39, 236);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 114;
            label5.Text = "Stock:";
            // 
            // BBuscarP
            // 
            BBuscarP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarP.Location = new Point(361, 176);
            BBuscarP.Margin = new Padding(3, 4, 3, 4);
            BBuscarP.Name = "BBuscarP";
            BBuscarP.Size = new Size(90, 35);
            BBuscarP.TabIndex = 113;
            BBuscarP.Text = "Buscar";
            BBuscarP.UseVisualStyleBackColor = true;
            BBuscarP.Click += BBuscarP_Click;
            // 
            // TProductoNombre
            // 
            TProductoNombre.Font = new Font("Microsoft Sans Serif", 12F);
            TProductoNombre.Location = new Point(121, 177);
            TProductoNombre.Margin = new Padding(3, 4, 3, 4);
            TProductoNombre.Name = "TProductoNombre";
            TProductoNombre.Size = new Size(234, 30);
            TProductoNombre.TabIndex = 112;
            // 
            // TProductoID
            // 
            TProductoID.Font = new Font("Microsoft Sans Serif", 12F);
            TProductoID.Location = new Point(39, 177);
            TProductoID.Margin = new Padding(3, 4, 3, 4);
            TProductoID.Name = "TProductoID";
            TProductoID.Size = new Size(76, 30);
            TProductoID.TabIndex = 111;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(39, 148);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 110;
            label4.Text = "Producto:";
            // 
            // BuscarC
            // 
            BuscarC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarC.Location = new Point(360, 92);
            BuscarC.Margin = new Padding(3, 4, 3, 4);
            BuscarC.Name = "BuscarC";
            BuscarC.Size = new Size(91, 35);
            BuscarC.TabIndex = 109;
            BuscarC.Text = "Buscar";
            BuscarC.UseVisualStyleBackColor = true;
            BuscarC.Click += BBuscarC_Click;
            // 
            // TClienteID
            // 
            TClienteID.Font = new Font("Microsoft Sans Serif", 12F);
            TClienteID.Location = new Point(39, 93);
            TClienteID.Margin = new Padding(3, 4, 3, 4);
            TClienteID.Name = "TClienteID";
            TClienteID.Size = new Size(76, 30);
            TClienteID.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(39, 64);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 107;
            label3.Text = "Cliente:";
            // 
            // TVendedorNombre
            // 
            TVendedorNombre.Font = new Font("Microsoft Sans Serif", 12F);
            TVendedorNombre.Location = new Point(688, 93);
            TVendedorNombre.Margin = new Padding(3, 4, 3, 4);
            TVendedorNombre.Name = "TVendedorNombre";
            TVendedorNombre.Size = new Size(270, 30);
            TVendedorNombre.TabIndex = 106;
            // 
            // TVendedorID
            // 
            TVendedorID.Font = new Font("Microsoft Sans Serif", 12F);
            TVendedorID.Location = new Point(606, 93);
            TVendedorID.Margin = new Padding(3, 4, 3, 4);
            TVendedorID.Name = "TVendedorID";
            TVendedorID.Size = new Size(76, 30);
            TVendedorID.TabIndex = 105;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(606, 64);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 104;
            label8.Text = "Vendedor:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(39, 12);
            label10.Name = "label10";
            label10.Size = new Size(160, 29);
            label10.TabIndex = 103;
            label10.Text = "Nueva Venta";
            // 
            // BConfirmar
            // 
            BConfirmar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BConfirmar.Location = new Point(836, 236);
            BConfirmar.Margin = new Padding(3, 4, 3, 4);
            BConfirmar.Name = "BConfirmar";
            BConfirmar.Size = new Size(122, 59);
            BConfirmar.TabIndex = 129;
            BConfirmar.Text = "Confirmar Venta";
            BConfirmar.UseVisualStyleBackColor = true;
            BConfirmar.Click += BConfirmarVenta_Click;
            // 
            // TTotal
            // 
            TTotal.Font = new Font("Microsoft Sans Serif", 12F);
            TTotal.Location = new Point(606, 181);
            TTotal.Margin = new Padding(3, 4, 3, 4);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(152, 30);
            TTotal.TabIndex = 128;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.Location = new Point(606, 152);
            label11.Name = "label11";
            label11.Size = new Size(62, 25);
            label11.TabIndex = 127;
            label11.Text = "Total:";
            // 
            // CBTipoV
            // 
            CBTipoV.FormattingEnabled = true;
            CBTipoV.Location = new Point(764, 181);
            CBTipoV.Margin = new Padding(3, 4, 3, 4);
            CBTipoV.Name = "CBTipoV";
            CBTipoV.Size = new Size(194, 28);
            CBTipoV.TabIndex = 126;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F);
            label12.Location = new Point(764, 152);
            label12.Name = "label12";
            label12.Size = new Size(162, 25);
            label12.TabIndex = 125;
            label12.Text = "Método de Pago:";
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1006, 955);
            Controls.Add(BConfirmar);
            Controls.Add(TTotal);
            Controls.Add(label11);
            Controls.Add(CBTipoV);
            Controls.Add(label12);
            Controls.Add(TClienteNombre);
            Controls.Add(dataGridView2);
            Controls.Add(BAgregar);
            Controls.Add(numericUpDown1);
            Controls.Add(TSubtotal);
            Controls.Add(label9);
            Controls.Add(TStock);
            Controls.Add(TPrecioV);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BBuscarP);
            Controls.Add(TProductoNombre);
            Controls.Add(TProductoID);
            Controls.Add(label4);
            Controls.Add(BuscarC);
            Controls.Add(TClienteID);
            Controls.Add(label3);
            Controls.Add(TVendedorNombre);
            Controls.Add(TVendedorID);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(BLimpiar);
            Controls.Add(CBFiltro);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(BBuscar);
            Controls.Add(TBuscarVenta);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Venta";
            Text = "Form2";
            Load += Venta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private TextBox TClienteNombre;
        private DataGridView dataGridView2;
        private Button BAgregar;
        private NumericUpDown numericUpDown1;
        private TextBox TSubtotal;
        private Label label9;
        private TextBox TStock;
        private TextBox TPrecioV;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button BBuscarP;
        private TextBox TProductoNombre;
        private TextBox TProductoID;
        private Label label4;
        private Button BuscarC;
        private TextBox TClienteID;
        private Label label3;
        private TextBox TVendedorNombre;
        private TextBox TVendedorID;
        private Label label8;
        private Label label10;
        private Button BConfirmar;
        private TextBox TTotal;
        private Label label11;
        private ComboBox CBTipoV;
        private Label label12;
    }
}