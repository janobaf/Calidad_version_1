namespace CapaPresentacion.becas
{
    partial class ListaAlumnosBecados
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
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.Salitbutton1 = new System.Windows.Forms.Button();
            this.Continuarbutton1 = new System.Windows.Forms.Button();
            this.DNItextBox1 = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.labelListaBecados = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Buscarbutton1.Location = new System.Drawing.Point(801, 95);
            this.Buscarbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(127, 42);
            this.Buscarbutton1.TabIndex = 50;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            // 
            // Salitbutton1
            // 
            this.Salitbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salitbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Salitbutton1.Location = new System.Drawing.Point(378, 441);
            this.Salitbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Salitbutton1.Name = "Salitbutton1";
            this.Salitbutton1.Size = new System.Drawing.Size(149, 54);
            this.Salitbutton1.TabIndex = 49;
            this.Salitbutton1.Text = "Salir";
            this.Salitbutton1.UseVisualStyleBackColor = true;
            // 
            // Continuarbutton1
            // 
            this.Continuarbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuarbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Continuarbutton1.Location = new System.Drawing.Point(110, 441);
            this.Continuarbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Continuarbutton1.Name = "Continuarbutton1";
            this.Continuarbutton1.Size = new System.Drawing.Size(148, 54);
            this.Continuarbutton1.TabIndex = 48;
            this.Continuarbutton1.Text = "Continuar";
            this.Continuarbutton1.UseVisualStyleBackColor = true;
            // 
            // DNItextBox1
            // 
            this.DNItextBox1.Location = new System.Drawing.Point(222, 104);
            this.DNItextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DNItextBox1.Name = "DNItextBox1";
            this.DNItextBox1.Size = new System.Drawing.Size(528, 22);
            this.DNItextBox1.TabIndex = 46;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(65, 104);
            this.dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(124, 25);
            this.dni.TabIndex = 45;
            this.dni.Text = "DNI Alumno:";
            // 
            // labelListaBecados
            // 
            this.labelListaBecados.AutoSize = true;
            this.labelListaBecados.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaBecados.Location = new System.Drawing.Point(322, 31);
            this.labelListaBecados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListaBecados.Name = "labelListaBecados";
            this.labelListaBecados.Size = new System.Drawing.Size(433, 41);
            this.labelListaBecados.TabIndex = 44;
            this.labelListaBecados.Text = "Listado de Alumnos Becados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(956, 259);
            this.dataGridView1.TabIndex = 51;
            // 
            // ListaAlumnosBecados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.Salitbutton1);
            this.Controls.Add(this.Continuarbutton1);
            this.Controls.Add(this.DNItextBox1);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.labelListaBecados);
            this.Name = "ListaAlumnosBecados";
            this.Text = "ListaAlumnosBecados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.Button Salitbutton1;
        private System.Windows.Forms.Button Continuarbutton1;
        private System.Windows.Forms.TextBox DNItextBox1;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label labelListaBecados;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}