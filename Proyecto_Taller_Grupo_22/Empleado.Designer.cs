namespace Proyecto_Taller_Grupo_22
{
    partial class Empleado
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
            dataGridView1 = new DataGridView();
            btnChangeStatus = new DataGridViewImageColumn();
            BEliminar = new Button();
            BAgregar = new Button();
            DTPCumple = new DateTimePicker();
            label8 = new Label();
            TDNI = new TextBox();
            label7 = new Label();
            label6 = new Label();
            RBMasculino = new RadioButton();
            RBFemenino = new RadioButton();
            TTelefono = new TextBox();
            label5 = new Label();
            TApellidoE = new TextBox();
            TEmail = new TextBox();
            TNombreE = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BAceptar = new Button();
            BTodos = new Button();
            BInactivos = new Button();
            BActivos = new Button();
            TNombreU = new TextBox();
            label9 = new Label();
            TContraseña = new TextBox();
            label10 = new Label();
            CBPerfil = new ComboBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnChangeStatus });
            dataGridView1.Location = new Point(12, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(860, 371);
            dataGridView1.TabIndex = 76;
            dataGridView1.CellClick += dataGridView1_CellClick;
            //dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.HeaderText = "Acción";
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.ReadOnly = true;
            btnChangeStatus.Width = 50;
            // 
            // BEliminar
            // 
            BEliminar.Font = new Font("Microsoft Sans Serif", 12F);
            BEliminar.Location = new Point(739, 139);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(133, 61);
            BEliminar.TabIndex = 75;
            BEliminar.Text = "Limpiar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Microsoft Sans Serif", 12F);
            BAgregar.Location = new Point(739, 63);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(133, 58);
            BAgregar.TabIndex = 74;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // DTPCumple
            // 
            DTPCumple.Font = new Font("Microsoft Sans Serif", 12F);
            DTPCumple.Location = new Point(457, 98);
            DTPCumple.Name = "DTPCumple";
            DTPCumple.Size = new Size(158, 26);
            DTPCumple.TabIndex = 73;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(349, 101);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 72;
            label8.Text = "Cumpleaños:";
            // 
            // TDNI
            // 
            TDNI.Font = new Font("Microsoft Sans Serif", 12F);
            TDNI.Location = new Point(457, 133);
            TDNI.Name = "TDNI";
            TDNI.Size = new Size(156, 26);
            TDNI.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(410, 136);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 70;
            label7.Text = "DNI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(40, 220);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(49, 20);
            label6.TabIndex = 69;
            label6.Text = "Sexo:";
            // 
            // RBMasculino
            // 
            RBMasculino.AutoSize = true;
            RBMasculino.Font = new Font("Microsoft Sans Serif", 12F);
            RBMasculino.Location = new Point(199, 218);
            RBMasculino.Name = "RBMasculino";
            RBMasculino.Size = new Size(98, 24);
            RBMasculino.TabIndex = 68;
            RBMasculino.Text = "Masculino";
            RBMasculino.UseVisualStyleBackColor = true;
            // 
            // RBFemenino
            // 
            RBFemenino.AutoSize = true;
            RBFemenino.Checked = true;
            RBFemenino.Font = new Font("Microsoft Sans Serif", 12F);
            RBFemenino.Location = new Point(95, 218);
            RBFemenino.Name = "RBFemenino";
            RBFemenino.Size = new Size(98, 24);
            RBFemenino.TabIndex = 67;
            RBFemenino.TabStop = true;
            RBFemenino.Text = "Femenino";
            RBFemenino.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Font = new Font("Microsoft Sans Serif", 12F);
            TTelefono.Location = new Point(457, 63);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(156, 26);
            TTelefono.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(376, 66);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 65;
            label5.Text = "Teléfono:";
            // 
            // TApellidoE
            // 
            TApellidoE.Font = new Font("Microsoft Sans Serif", 12F);
            TApellidoE.Location = new Point(141, 98);
            TApellidoE.Name = "TApellidoE";
            TApellidoE.Size = new Size(156, 26);
            TApellidoE.TabIndex = 64;
            // 
            // TEmail
            // 
            TEmail.Font = new Font("Microsoft Sans Serif", 12F);
            TEmail.Location = new Point(141, 133);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(156, 26);
            TEmail.TabIndex = 63;
            // 
            // TNombreE
            // 
            TNombreE.Font = new Font("Microsoft Sans Serif", 12F);
            TNombreE.Location = new Point(141, 63);
            TNombreE.Name = "TNombreE";
            TNombreE.Size = new Size(156, 26);
            TNombreE.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(78, 136);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 61;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(66, 101);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 60;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(66, 66);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 59;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 58;
            label1.Text = "Empleado";
            // 
            // BAceptar
            // 
            BAceptar.Font = new Font("Microsoft Sans Serif", 12F);
            BAceptar.Location = new Point(739, 217);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(133, 61);
            BAceptar.TabIndex = 80;
            BAceptar.Text = "Guardar Cambios";
            BAceptar.UseVisualStyleBackColor = true;
            BAceptar.Click += BAceptar_Click;
            // 
            // BTodos
            // 
            BTodos.Font = new Font("Microsoft Sans Serif", 12F);
            BTodos.Location = new Point(12, 278);
            BTodos.Name = "BTodos";
            BTodos.Size = new Size(106, 35);
            BTodos.TabIndex = 79;
            BTodos.Text = "Todos";
            BTodos.UseVisualStyleBackColor = true;
            BTodos.Click += BTodos_Click;
            // 
            // BInactivos
            // 
            BInactivos.Font = new Font("Microsoft Sans Serif", 12F);
            BInactivos.Location = new Point(236, 278);
            BInactivos.Name = "BInactivos";
            BInactivos.Size = new Size(106, 35);
            BInactivos.TabIndex = 78;
            BInactivos.Text = "Inactivos";
            BInactivos.UseVisualStyleBackColor = true;
            BInactivos.Click += BInactivos_Click;
            // 
            // BActivos
            // 
            BActivos.Font = new Font("Microsoft Sans Serif", 12F);
            BActivos.Location = new Point(124, 278);
            BActivos.Name = "BActivos";
            BActivos.Size = new Size(106, 35);
            BActivos.TabIndex = 77;
            BActivos.Text = "Activos";
            BActivos.UseVisualStyleBackColor = true;
            BActivos.Click += BActivos_Click;
            // 
            // TNombreU
            // 
            TNombreU.Font = new Font("Microsoft Sans Serif", 12F);
            TNombreU.Location = new Point(141, 168);
            TNombreU.Name = "TNombreU";
            TNombreU.Size = new Size(156, 26);
            TNombreU.TabIndex = 84;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(11, 171);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 82;
            label9.Text = "Nombre Usuario";
            // 
            // TContraseña
            // 
            TContraseña.Font = new Font("Microsoft Sans Serif", 12F);
            TContraseña.Location = new Point(457, 168);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(156, 26);
            TContraseña.TabIndex = 86;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(355, 171);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 85;
            label10.Text = "Contraseña:";
            // 
            // CBPerfil
            // 
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(457, 217);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(121, 23);
            CBPerfil.TabIndex = 87;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.Location = new Point(403, 220);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 88;
            label11.Text = "Perfil:";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(884, 702);
            Controls.Add(label11);
            Controls.Add(CBPerfil);
            Controls.Add(TContraseña);
            Controls.Add(label10);
            Controls.Add(TNombreU);
            Controls.Add(label9);
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
            Controls.Add(TApellidoE);
            Controls.Add(TEmail);
            Controls.Add(TNombreE);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Empleado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Empleados";
            Load += Empleado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button BEliminar;
        private Button BAgregar;
        private DateTimePicker DTPCumple;
        private Label label8;
        private TextBox TDNI;
        private Label label7;
        private Label label6;
        private RadioButton RBMasculino;
        private RadioButton RBFemenino;
        private TextBox TTelefono;
        private Label label5;
        private TextBox TApellidoE;
        private TextBox TEmail;
        private TextBox TNombreE;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BAceptar;
        private Button BTodos;
        private Button BInactivos;
        private Button BActivos;
        private TextBox TNombreU;
        private Label label9;
        private TextBox TContraseña;
        private Label label10;
        private ComboBox CBPerfil;
        private Label label11;
        private DataGridViewImageColumn btnChangeStatusI;
        private DataGridViewImageColumn btnChangeStatus;
    }
}