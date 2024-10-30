namespace Proyecto_Taller_Grupo_22
{
    partial class Cliente
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
            TEmail = new TextBox();
            TNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TApellido = new TextBox();
            TTelefono = new TextBox();
            label5 = new Label();
            RBFemenino = new RadioButton();
            RBMasculino = new RadioButton();
            label6 = new Label();
            TDNI = new TextBox();
            label7 = new Label();
            label8 = new Label();
            DTPCumple = new DateTimePicker();
            BEliminar = new Button();
            BAgregar = new Button();
            BInactivos = new Button();
            BActivos = new Button();
            dataGridView1 = new DataGridView();
            BTodos = new Button();
            BAceptar = new Button();
            btnChangeStatus = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TEmail
            // 
            TEmail.Font = new Font("Microsoft Sans Serif", 12F);
            TEmail.Location = new Point(93, 141);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(156, 26);
            TEmail.TabIndex = 34;
            // 
            // TNombre
            // 
            TNombre.Font = new Font("Microsoft Sans Serif", 12F);
            TNombre.Location = new Point(93, 71);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(156, 26);
            TNombre.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(30, 144);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 30;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(18, 111);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 29;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 28;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 27;
            label1.Text = "Clientes";
            // 
            // TApellido
            // 
            TApellido.Font = new Font("Microsoft Sans Serif", 12F);
            TApellido.Location = new Point(93, 106);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(156, 26);
            TApellido.TabIndex = 39;
            // 
            // TTelefono
            // 
            TTelefono.Font = new Font("Microsoft Sans Serif", 12F);
            TTelefono.Location = new Point(409, 71);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(156, 26);
            TTelefono.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(328, 74);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 40;
            label5.Text = "Teléfono:";
            // 
            // RBFemenino
            // 
            RBFemenino.AutoSize = true;
            RBFemenino.Checked = true;
            RBFemenino.Font = new Font("Microsoft Sans Serif", 12F);
            RBFemenino.Location = new Point(93, 186);
            RBFemenino.Name = "RBFemenino";
            RBFemenino.Size = new Size(98, 24);
            RBFemenino.TabIndex = 42;
            RBFemenino.TabStop = true;
            RBFemenino.Text = "Femenino";
            RBFemenino.UseVisualStyleBackColor = true;
            // 
            // RBMasculino
            // 
            RBMasculino.AutoSize = true;
            RBMasculino.Font = new Font("Microsoft Sans Serif", 12F);
            RBMasculino.Location = new Point(197, 186);
            RBMasculino.Name = "RBMasculino";
            RBMasculino.Size = new Size(98, 24);
            RBMasculino.TabIndex = 43;
            RBMasculino.Text = "Masculino";
            RBMasculino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(38, 188);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(49, 20);
            label6.TabIndex = 44;
            label6.Text = "Sexo:";
            // 
            // TDNI
            // 
            TDNI.Font = new Font("Microsoft Sans Serif", 12F);
            TDNI.Location = new Point(409, 141);
            TDNI.Name = "TDNI";
            TDNI.Size = new Size(156, 26);
            TDNI.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(362, 144);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 45;
            label7.Text = "DNI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(301, 111);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 47;
            label8.Text = "Cumpleaños:";
            // 
            // DTPCumple
            // 
            DTPCumple.Font = new Font("Microsoft Sans Serif", 12F);
            DTPCumple.Location = new Point(409, 106);
            DTPCumple.Name = "DTPCumple";
            DTPCumple.Size = new Size(158, 26);
            DTPCumple.TabIndex = 48;
            // 
            // BEliminar
            // 
            BEliminar.Font = new Font("Microsoft Sans Serif", 12F);
            BEliminar.Location = new Point(732, 110);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(133, 61);
            BEliminar.TabIndex = 54;
            BEliminar.Text = "Limpiar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Microsoft Sans Serif", 12F);
            BAgregar.Location = new Point(732, 34);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(133, 58);
            BAgregar.TabIndex = 53;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BInactivos
            // 
            BInactivos.Font = new Font("Microsoft Sans Serif", 12F);
            BInactivos.Location = new Point(242, 235);
            BInactivos.Name = "BInactivos";
            BInactivos.Size = new Size(106, 35);
            BInactivos.TabIndex = 57;
            BInactivos.Text = "Inactivos";
            BInactivos.UseVisualStyleBackColor = true;
            BInactivos.Click += BInactivos_Click;
            // 
            // BActivos
            // 
            BActivos.Font = new Font("Microsoft Sans Serif", 12F);
            BActivos.Location = new Point(130, 235);
            BActivos.Name = "BActivos";
            BActivos.Size = new Size(106, 35);
            BActivos.TabIndex = 56;
            BActivos.Text = "Activos";
            BActivos.UseVisualStyleBackColor = true;
            BActivos.Click += BActivos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnChangeStatus });
            dataGridView1.Location = new Point(18, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(847, 416);
            dataGridView1.TabIndex = 55;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // BTodos
            // 
            BTodos.Font = new Font("Microsoft Sans Serif", 12F);
            BTodos.Location = new Point(18, 235);
            BTodos.Name = "BTodos";
            BTodos.Size = new Size(106, 35);
            BTodos.TabIndex = 58;
            BTodos.Text = "Todos";
            BTodos.UseVisualStyleBackColor = true;
            BTodos.Click += BTodos_Click;
            // 
            // BAceptar
            // 
            BAceptar.Font = new Font("Microsoft Sans Serif", 12F);
            BAceptar.Location = new Point(732, 188);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(133, 61);
            BAceptar.TabIndex = 59;
            BAceptar.Text = "Guardar Cambios";
            BAceptar.UseVisualStyleBackColor = true;
            BAceptar.Click += BAceptar_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnChangeStatus.HeaderText = "Acción";
            btnChangeStatus.Image = Properties.Resources.Altas_y_bajas;
            btnChangeStatus.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnChangeStatus.MinimumWidth = 6;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.ReadOnly = true;
            btnChangeStatus.Width = 60;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(884, 704);
            Controls.Add(BAceptar);
            Controls.Add(BTodos);
            Controls.Add(BInactivos);
            Controls.Add(BActivos);
            Controls.Add(dataGridView1);
            Controls.Add(BEliminar);
            Controls.Add(BAgregar);
            Controls.Add(DTPCumple);
            Controls.Add(label8);
            Controls.Add(TDNI);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(RBMasculino);
            Controls.Add(RBFemenino);
            Controls.Add(TTelefono);
            Controls.Add(label5);
            Controls.Add(TApellido);
            Controls.Add(TEmail);
            Controls.Add(TNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clientes";
            Load += Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TEmail;
        private TextBox TNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TApellido;
        private TextBox TTelefono;
        private Label label5;
        private RadioButton RBFemenino;
        private RadioButton RBMasculino;
        private Label label6;
        private TextBox TDNI;
        private Label label7;
        private Label label8;
        private DateTimePicker DTPCumple;
        private Button BEliminar;
        private Button BAgregar;
        private Button BInactivos;
        private Button BActivos;
        private DataGridView dataGridView1;
        private Button BTodos;
        private Button BAceptar;
        private DataGridViewImageColumn btnChangeStatus;
    }
}