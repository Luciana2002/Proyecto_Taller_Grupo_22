﻿namespace Proyecto_Taller_Grupo_22
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
            btnBackup = new Button();
            btnConectar = new Button();
            btnSeleccionarRuta = new Button();
            txtRutaGuardar = new TextBox();
            cmbBasesDatos = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 62);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 0;
            label1.Text = "Back Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(119, 202);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 1;
            label2.Text = "Ruta Guardar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(107, 137);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 2;
            label3.Text = "Base de Datos";
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.Gainsboro;
            btnBackup.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackup.Location = new Point(262, 273);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(154, 52);
            btnBackup.TabIndex = 3;
            btnBackup.Text = "Guardar";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.Gainsboro;
            btnConectar.Font = new Font("Microsoft Sans Serif", 12F);
            btnConectar.Location = new Point(448, 131);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(96, 36);
            btnConectar.TabIndex = 4;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnSeleccionarRuta
            // 
            btnSeleccionarRuta.BackColor = Color.Gainsboro;
            btnSeleccionarRuta.Font = new Font("Microsoft Sans Serif", 12F);
            btnSeleccionarRuta.Location = new Point(448, 196);
            btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            btnSeleccionarRuta.Size = new Size(96, 36);
            btnSeleccionarRuta.TabIndex = 5;
            btnSeleccionarRuta.Text = "Ruta";
            btnSeleccionarRuta.UseVisualStyleBackColor = false;
            btnSeleccionarRuta.Click += btnSeleccionarRuta_Click;
            // 
            // txtRutaGuardar
            // 
            txtRutaGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            txtRutaGuardar.Location = new Point(256, 201);
            txtRutaGuardar.Name = "txtRutaGuardar";
            txtRutaGuardar.Size = new Size(184, 30);
            txtRutaGuardar.TabIndex = 7;
            // 
            // cmbBasesDatos
            // 
            cmbBasesDatos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBasesDatos.FormattingEnabled = true;
            cmbBasesDatos.Location = new Point(256, 131);
            cmbBasesDatos.Name = "cmbBasesDatos";
            cmbBasesDatos.Size = new Size(184, 33);
            cmbBasesDatos.TabIndex = 8;
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(693, 385);
            Controls.Add(cmbBasesDatos);
            Controls.Add(txtRutaGuardar);
            Controls.Add(btnSeleccionarRuta);
            Controls.Add(btnConectar);
            Controls.Add(btnBackup);
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
        private Button btnBackup;
        private Button btnConectar;
        private Button btnSeleccionarRuta;
        private TextBox txtRutaGuardar;
        private ComboBox cmbBasesDatos;
    }
}