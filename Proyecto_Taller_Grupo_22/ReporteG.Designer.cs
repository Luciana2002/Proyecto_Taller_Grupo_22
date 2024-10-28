namespace Proyecto_Taller_Grupo_22
{
    partial class ReporteG
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
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 38);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 0;
            label1.Text = "Reportes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 11.25F);
            button1.Location = new Point(213, 280);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 1;
            button1.Text = "Recaudación";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(356, 92);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 31);
            label2.TabIndex = 2;
            label2.Text = "Elegir fechas";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 11.25F);
            button2.Location = new Point(356, 280);
            button2.Name = "button2";
            button2.Size = new Size(137, 45);
            button2.TabIndex = 3;
            button2.Text = "Más vendidos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 11.25F);
            button3.Location = new Point(499, 280);
            button3.Name = "button3";
            button3.Size = new Size(137, 45);
            button3.TabIndex = 4;
            button3.Text = "Total ventas";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.Location = new Point(336, 250);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 24);
            label3.TabIndex = 5;
            label3.Text = "Generar Reporte por:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpFechaFin);
            panel1.Controls.Add(dtpFechaInicio);
            panel1.Location = new Point(177, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 100);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(353, 19);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 29);
            label5.TabIndex = 4;
            label5.Text = "Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 19);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 29);
            label4.TabIndex = 3;
            label4.Text = "Desde:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(311, 46);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(144, 26);
            dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Microsoft Sans Serif", 9.75F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(37, 46);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(144, 26);
            dtpFechaInicio.TabIndex = 0;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(524, 392);
            button4.Name = "button4";
            button4.Size = new Size(80, 30);
            button4.TabIndex = 82;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F);
            textBox2.Location = new Point(313, 392);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 30);
            textBox2.TabIndex = 81;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(240, 392);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(67, 30);
            textBox3.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(240, 360);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 79;
            label6.Text = "Vendedor:";
            // 
            // ReporteG
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(887, 498);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "ReporteG";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reportes";
            Load += Reporte_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Label label3;
        private Panel panel1;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label label5;
        private Label label4;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
    }
}