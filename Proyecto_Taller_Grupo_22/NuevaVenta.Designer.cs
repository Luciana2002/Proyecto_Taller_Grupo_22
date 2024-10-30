namespace Proyecto_Taller_Grupo_22
{
    partial class NuevaVenta
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
            TVendedorID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TVendedorNombre = new TextBox();
            TClienteID = new TextBox();
            label3 = new Label();
            BuscarC = new Button();
            label4 = new Label();
            TProductoNombre = new TextBox();
            TProductoID = new TextBox();
            BBuscarP = new Button();
            label5 = new Label();
            label6 = new Label();
            TPrecioV = new TextBox();
            label7 = new Label();
            TStock = new TextBox();
            TSubtotal = new TextBox();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            BAgregar = new Button();
            BConfirmar = new Button();
            TTotal = new TextBox();
            label10 = new Label();
            CBTipoV = new ComboBox();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            TClienteNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TVendedorID
            // 
            TVendedorID.Font = new Font("Microsoft Sans Serif", 12F);
            TVendedorID.Location = new Point(28, 92);
            TVendedorID.Name = "TVendedorID";
            TVendedorID.Size = new Size(67, 26);
            TVendedorID.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(28, 69);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 55;
            label2.Text = "Vendedor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 54;
            label1.Text = "Nueva Venta";
            // 
            // TVendedorNombre
            // 
            TVendedorNombre.Font = new Font("Microsoft Sans Serif", 12F);
            TVendedorNombre.Location = new Point(101, 92);
            TVendedorNombre.Name = "TVendedorNombre";
            TVendedorNombre.Size = new Size(205, 26);
            TVendedorNombre.TabIndex = 74;
            // 
            // TClienteID
            // 
            TClienteID.Font = new Font("Microsoft Sans Serif", 12F);
            TClienteID.Location = new Point(427, 92);
            TClienteID.Name = "TClienteID";
            TClienteID.Size = new Size(67, 26);
            TClienteID.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(427, 69);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 75;
            label3.Text = "Cliente:";
            // 
            // BuscarC
            // 
            BuscarC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarC.Location = new Point(711, 92);
            BuscarC.Name = "BuscarC";
            BuscarC.Size = new Size(80, 26);
            BuscarC.TabIndex = 78;
            BuscarC.Text = "Buscar";
            BuscarC.UseVisualStyleBackColor = true;
            BuscarC.Click += BBuscarC_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(28, 153);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 79;
            label4.Text = "Producto:";
            // 
            // TProductoNombre
            // 
            TProductoNombre.Font = new Font("Microsoft Sans Serif", 12F);
            TProductoNombre.Location = new Point(101, 176);
            TProductoNombre.Name = "TProductoNombre";
            TProductoNombre.Size = new Size(205, 26);
            TProductoNombre.TabIndex = 81;
            // 
            // TProductoID
            // 
            TProductoID.Font = new Font("Microsoft Sans Serif", 12F);
            TProductoID.Location = new Point(28, 176);
            TProductoID.Name = "TProductoID";
            TProductoID.Size = new Size(67, 26);
            TProductoID.TabIndex = 80;
            // 
            // BBuscarP
            // 
            BBuscarP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarP.Location = new Point(312, 176);
            BBuscarP.Name = "BBuscarP";
            BBuscarP.Size = new Size(79, 26);
            BBuscarP.TabIndex = 82;
            BBuscarP.Text = "Buscar";
            BBuscarP.UseVisualStyleBackColor = true;
            BBuscarP.Click += BBuscarP_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(29, 220);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 83;
            label5.Text = "Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(249, 221);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 85;
            label6.Text = "Precio Venta:";
            // 
            // TPrecioV
            // 
            TPrecioV.Font = new Font("Microsoft Sans Serif", 12F);
            TPrecioV.Location = new Point(249, 244);
            TPrecioV.Name = "TPrecioV";
            TPrecioV.Size = new Size(144, 26);
            TPrecioV.TabIndex = 88;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(139, 220);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 87;
            label7.Text = "Cantidad:";
            // 
            // TStock
            // 
            TStock.Font = new Font("Microsoft Sans Serif", 12F);
            TStock.Location = new Point(29, 244);
            TStock.Name = "TStock";
            TStock.Size = new Size(104, 26);
            TStock.TabIndex = 89;
            // 
            // TSubtotal
            // 
            TSubtotal.Font = new Font("Microsoft Sans Serif", 12F);
            TSubtotal.Location = new Point(399, 244);
            TSubtotal.Name = "TSubtotal";
            TSubtotal.Size = new Size(144, 26);
            TSubtotal.TabIndex = 93;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(399, 220);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 92;
            label9.Text = "Subtotal:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(139, 244);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(104, 23);
            numericUpDown1.TabIndex = 94;
            numericUpDown1.ValueChanged += CalcularSubtotal;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAgregar.Location = new Point(549, 244);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(80, 26);
            BAgregar.TabIndex = 95;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BConfirmar
            // 
            BConfirmar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BConfirmar.Location = new Point(699, 576);
            BConfirmar.Name = "BConfirmar";
            BConfirmar.Size = new Size(80, 26);
            BConfirmar.TabIndex = 100;
            BConfirmar.Text = "Confirmar";
            BConfirmar.UseVisualStyleBackColor = true;
            BConfirmar.Click += BConfirmarVenta_Click;
            // 
            // TTotal
            // 
            TTotal.Font = new Font("Microsoft Sans Serif", 12F);
            TTotal.Location = new Point(549, 576);
            TTotal.Name = "TTotal";
            TTotal.Size = new Size(144, 26);
            TTotal.TabIndex = 99;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(549, 552);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 98;
            label10.Text = "Total:";
            // 
            // CBTipoV
            // 
            CBTipoV.FormattingEnabled = true;
            CBTipoV.Location = new Point(399, 576);
            CBTipoV.Name = "CBTipoV";
            CBTipoV.Size = new Size(144, 23);
            CBTipoV.TabIndex = 97;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.Location = new Point(399, 552);
            label11.Name = "label11";
            label11.Size = new Size(130, 20);
            label11.TabIndex = 96;
            label11.Text = "Método de Pago:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 275);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(750, 274);
            dataGridView1.TabIndex = 101;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // TClienteNombre
            // 
            TClienteNombre.Font = new Font("Microsoft Sans Serif", 12F);
            TClienteNombre.Location = new Point(500, 92);
            TClienteNombre.Name = "TClienteNombre";
            TClienteNombre.Size = new Size(205, 26);
            TClienteNombre.TabIndex = 102;
            // 
            // NuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(849, 650);
            Controls.Add(TClienteNombre);
            Controls.Add(dataGridView1);
            Controls.Add(BConfirmar);
            Controls.Add(TTotal);
            Controls.Add(label10);
            Controls.Add(CBTipoV);
            Controls.Add(label11);
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
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevaVenta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Venta";
            Load += NuevaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TVendedorID;
        private Label label2;
        private Label label1;
        private TextBox TVendedorNombre;
        private TextBox TClienteID;
        private Label label3;
        private Button BuscarC;
        private Label label4;
        private TextBox TProductoNombre;
        private TextBox TProductoID;
        private Button BBuscarP;
        private Label label5;
        private Label label6;
        private TextBox TPrecioV;
        private Label label7;
        private TextBox TStock;
        private TextBox TSubtotal;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private Button BAgregar;
        private Button BConfirmar;
        private TextBox TTotal;
        private Label label10;
        private ComboBox CBTipoV;
        private Label label11;
        private DataGridView dataGridView1;
        private TextBox TClienteNombre;
    }
}