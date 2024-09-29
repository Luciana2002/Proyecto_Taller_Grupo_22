namespace Proyecto_Taller_Grupo_22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TUsuario = new TextBox();
            TContrasena = new TextBox();
            button1 = new Button();
            BLimpiar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(325, 131);
            label1.Name = "label1";
            label1.Size = new Size(172, 29);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(163, 191);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(128, 239);
            label3.Name = "label3";
            label3.Size = new Size(122, 24);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TUsuario
            // 
            TUsuario.Font = new Font("Microsoft Sans Serif", 14.25F);
            TUsuario.Location = new Point(256, 191);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(314, 29);
            TUsuario.TabIndex = 3;
            // 
            // TContrasena
            // 
            TContrasena.Font = new Font("Microsoft Sans Serif", 14.25F);
            TContrasena.Location = new Point(256, 239);
            TContrasena.Name = "TContrasena";
            TContrasena.PasswordChar = '*';
            TContrasena.Size = new Size(314, 29);
            TContrasena.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(313, 288);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 5;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BLogin_Click;
            // 
            // BLimpiar
            // 
            BLimpiar.BackColor = Color.Gainsboro;
            BLimpiar.Cursor = Cursors.IBeam;
            BLimpiar.FlatStyle = FlatStyle.Popup;
            BLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BLimpiar.Location = new Point(415, 288);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(94, 43);
            BLimpiar.TabIndex = 9;
            BLimpiar.Text = "Limpiar";
            BLimpiar.UseVisualStyleBackColor = false;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(297, 61);
            label4.Name = "label4";
            label4.Size = new Size(230, 37);
            label4.TabIndex = 10;
            label4.Text = "MAGIC SHOP";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(BLimpiar);
            Controls.Add(button1);
            Controls.Add(TContrasena);
            Controls.Add(TUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TUsuario;
        private TextBox TContrasena;
        private Button button1;
        private Button BLimpiar;
        private Label label4;
    }
}
