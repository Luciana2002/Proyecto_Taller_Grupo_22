namespace Proyecto_Taller_Grupo_22
{
    partial class Usuario
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
            FotoUsuario = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtApellido = new TextBox();
            TxtSexo = new TextBox();
            TxtEmail = new TextBox();
            TxtDNI = new TextBox();
            TxtTelefono = new TextBox();
            TxtNombre = new TextBox();
            TxtCumpleaños = new TextBox();
            ((System.ComponentModel.ISupportInitialize)FotoUsuario).BeginInit();
            SuspendLayout();
            // 
            // FotoUsuario
            // 
            FotoUsuario.BackgroundImage = Properties.Resources.default_profile_account_unknown_icon_black_silhouette_free_vector;
            FotoUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            FotoUsuario.Location = new Point(321, 41);
            FotoUsuario.Name = "FotoUsuario";
            FotoUsuario.Size = new Size(100, 95);
            FotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            FotoUsuario.TabIndex = 0;
            FotoUsuario.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.Location = new Point(264, 174);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.Location = new Point(264, 213);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.Location = new Point(289, 252);
            label3.Name = "label3";
            label3.Size = new Size(59, 24);
            label3.TabIndex = 3;
            label3.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F);
            label4.Location = new Point(286, 291);
            label4.Name = "label4";
            label4.Size = new Size(62, 24);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F);
            label5.Location = new Point(302, 330);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 5;
            label5.Text = "DNI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F);
            label6.Location = new Point(258, 369);
            label6.Name = "label6";
            label6.Size = new Size(90, 24);
            label6.TabIndex = 6;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F);
            label7.Location = new Point(226, 408);
            label7.Name = "label7";
            label7.Size = new Size(122, 24);
            label7.TabIndex = 7;
            label7.Text = "Cumpleaños:";
            // 
            // TxtApellido
            // 
            TxtApellido.Font = new Font("Segoe UI", 14.25F);
            TxtApellido.Location = new Point(354, 209);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.ReadOnly = true;
            TxtApellido.Size = new Size(163, 33);
            TxtApellido.TabIndex = 8;
            // 
            // TxtSexo
            // 
            TxtSexo.Font = new Font("Segoe UI", 14.25F);
            TxtSexo.Location = new Point(354, 248);
            TxtSexo.Name = "TxtSexo";
            TxtSexo.ReadOnly = true;
            TxtSexo.Size = new Size(163, 33);
            TxtSexo.TabIndex = 9;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Segoe UI", 14.25F);
            TxtEmail.Location = new Point(354, 287);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.ReadOnly = true;
            TxtEmail.Size = new Size(163, 33);
            TxtEmail.TabIndex = 10;
            // 
            // TxtDNI
            // 
            TxtDNI.Font = new Font("Segoe UI", 14.25F);
            TxtDNI.Location = new Point(354, 326);
            TxtDNI.Name = "TxtDNI";
            TxtDNI.ReadOnly = true;
            TxtDNI.Size = new Size(163, 33);
            TxtDNI.TabIndex = 11;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Font = new Font("Segoe UI", 14.25F);
            TxtTelefono.Location = new Point(354, 365);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.ReadOnly = true;
            TxtTelefono.Size = new Size(163, 33);
            TxtTelefono.TabIndex = 12;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Segoe UI", 14.25F);
            TxtNombre.Location = new Point(354, 170);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.ReadOnly = true;
            TxtNombre.Size = new Size(163, 33);
            TxtNombre.TabIndex = 13;
            // 
            // TxtCumpleaños
            // 
            TxtCumpleaños.Font = new Font("Segoe UI", 14.25F);
            TxtCumpleaños.Location = new Point(354, 404);
            TxtCumpleaños.Name = "TxtCumpleaños";
            TxtCumpleaños.ReadOnly = true;
            TxtCumpleaños.Size = new Size(163, 33);
            TxtCumpleaños.TabIndex = 14;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(782, 496);
            Controls.Add(TxtCumpleaños);
            Controls.Add(TxtNombre);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtDNI);
            Controls.Add(TxtEmail);
            Controls.Add(TxtSexo);
            Controls.Add(TxtApellido);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FotoUsuario);
            Name = "Usuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)FotoUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FotoUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtApellido;
        private TextBox TxtSexo;
        private TextBox TxtEmail;
        private TextBox TxtDNI;
        private TextBox TxtTelefono;
        private TextBox TxtNombre;
        private TextBox TxtCumpleaños;
    }
}