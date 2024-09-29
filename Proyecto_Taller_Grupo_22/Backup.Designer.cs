namespace Proyecto_Taller_Grupo_22
{
    partial class Backup
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
            label2 = new Label();
            label3 = new Label();
            BGuardarBackup = new Button();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 62);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Back Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(140, 204);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Ruta Guardar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(132, 133);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "Base de Datos";
            // 
            // BGuardarBackup
            // 
            BGuardarBackup.BackColor = Color.Gainsboro;
            BGuardarBackup.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGuardarBackup.Location = new Point(262, 273);
            BGuardarBackup.Name = "BGuardarBackup";
            BGuardarBackup.Size = new Size(154, 52);
            BGuardarBackup.TabIndex = 3;
            BGuardarBackup.Text = "Guardar";
            BGuardarBackup.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Location = new Point(448, 125);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 4;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.Location = new Point(448, 196);
            button2.Name = "button2";
            button2.Size = new Size(96, 36);
            button2.TabIndex = 5;
            button2.Text = "Ruta";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(256, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 28);
            comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(256, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 26);
            textBox1.TabIndex = 7;
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(693, 385);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BGuardarBackup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Backup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Backup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BGuardarBackup;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}