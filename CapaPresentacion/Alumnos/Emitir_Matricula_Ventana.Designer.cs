namespace CapaPresentacion.Pagos
{
    partial class Emitir_Matricula_Ventana
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
            this.label6 = new System.Windows.Forms.Label();
            this.Vuelto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dni_txt = new System.Windows.Forms.TextBox();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.DineroRecibido_txt = new System.Windows.Forms.TextBox();
            this.vuelto_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreAlumno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Dinero recibido";
            // 
            // Vuelto
            // 
            this.Vuelto.AutoSize = true;
            this.Vuelto.Location = new System.Drawing.Point(44, 207);
            this.Vuelto.Name = "Vuelto";
            this.Vuelto.Size = new System.Drawing.Size(37, 13);
            this.Vuelto.TabIndex = 25;
            this.Vuelto.Text = "Vuelto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total A pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dni Alumno";
            // 
            // dni_txt
            // 
            this.dni_txt.BackColor = System.Drawing.SystemColors.Window;
            this.dni_txt.Location = new System.Drawing.Point(185, 32);
            this.dni_txt.Name = "dni_txt";
            this.dni_txt.Size = new System.Drawing.Size(100, 20);
            this.dni_txt.TabIndex = 29;
            // 
            // Total_txt
            // 
            this.Total_txt.Location = new System.Drawing.Point(185, 124);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.Size = new System.Drawing.Size(100, 20);
            this.Total_txt.TabIndex = 33;
            this.Total_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // DineroRecibido_txt
            // 
            this.DineroRecibido_txt.Location = new System.Drawing.Point(185, 160);
            this.DineroRecibido_txt.Name = "DineroRecibido_txt";
            this.DineroRecibido_txt.Size = new System.Drawing.Size(100, 20);
            this.DineroRecibido_txt.TabIndex = 34;
            // 
            // vuelto_txt
            // 
            this.vuelto_txt.Location = new System.Drawing.Point(185, 200);
            this.vuelto_txt.Name = "vuelto_txt";
            this.vuelto_txt.Size = new System.Drawing.Size(100, 20);
            this.vuelto_txt.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 76);
            this.button1.TabIndex = 36;
            this.button1.Text = "aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Alumno";
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.Location = new System.Drawing.Point(185, 71);
            this.NombreAlumno.Name = "NombreAlumno";
            this.NombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.NombreAlumno.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 32);
            this.button2.TabIndex = 37;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Emitir_Matricula_Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vuelto_txt);
            this.Controls.Add(this.DineroRecibido_txt);
            this.Controls.Add(this.Total_txt);
            this.Controls.Add(this.NombreAlumno);
            this.Controls.Add(this.dni_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Vuelto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Emitir_Matricula_Ventana";
            this.Text = "Emitir_Matricula_Ventana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Vuelto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni_txt;
        private System.Windows.Forms.TextBox Total_txt;
        private System.Windows.Forms.TextBox DineroRecibido_txt;
        private System.Windows.Forms.TextBox vuelto_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreAlumno;
        private System.Windows.Forms.Button button2;
    }
}