namespace CapaPresentacion
{
    partial class ListarAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarAlumnos));
            this.Titulolabel6 = new System.Windows.Forms.Label();
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.Atrasbutton1 = new System.Windows.Forms.Button();
            this.Salitbutton1 = new System.Windows.Forms.Button();
            this.DNItextBox1 = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradoAlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulolabel6
            // 
            this.Titulolabel6.AutoSize = true;
            this.Titulolabel6.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel6.Location = new System.Drawing.Point(505, 14);
            this.Titulolabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulolabel6.Name = "Titulolabel6";
            this.Titulolabel6.Size = new System.Drawing.Size(218, 41);
            this.Titulolabel6.TabIndex = 59;
            this.Titulolabel6.Text = "Listar Alumno";
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Buscarbutton1.Location = new System.Drawing.Point(744, 91);
            this.Buscarbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(127, 42);
            this.Buscarbutton1.TabIndex = 57;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click);
            // 
            // Atrasbutton1
            // 
            this.Atrasbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atrasbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Atrasbutton1.Location = new System.Drawing.Point(124, 267);
            this.Atrasbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Atrasbutton1.Name = "Atrasbutton1";
            this.Atrasbutton1.Size = new System.Drawing.Size(148, 54);
            this.Atrasbutton1.TabIndex = 56;
            this.Atrasbutton1.Text = "Atras";
            this.Atrasbutton1.UseVisualStyleBackColor = true;
            // 
            // Salitbutton1
            // 
            this.Salitbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salitbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Salitbutton1.Location = new System.Drawing.Point(835, 267);
            this.Salitbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salitbutton1.Name = "Salitbutton1";
            this.Salitbutton1.Size = new System.Drawing.Size(149, 54);
            this.Salitbutton1.TabIndex = 55;
            this.Salitbutton1.Text = "Salir";
            this.Salitbutton1.UseVisualStyleBackColor = true;
            this.Salitbutton1.Click += new System.EventHandler(this.Salitbutton1_Click);
            // 
            // DNItextBox1
            // 
            this.DNItextBox1.Location = new System.Drawing.Point(193, 92);
            this.DNItextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DNItextBox1.Name = "DNItextBox1";
            this.DNItextBox1.Size = new System.Drawing.Size(528, 22);
            this.DNItextBox1.TabIndex = 48;
            this.DNItextBox1.TextChanged += new System.EventHandler(this.DNItextBox1_TextChanged);
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(93, 91);
            this.dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(50, 25);
            this.dni.TabIndex = 47;
            this.dni.Text = "DNI:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ApellidoPa,
            this.ApellidoMaterno,
            this.DniAlu,
            this.CorreoAlu,
            this.fech,
            this.GradoAlu});
            this.dataGridView1.Location = new System.Drawing.Point(75, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(999, 108);
            this.dataGridView1.TabIndex = 46;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // ApellidoPa
            // 
            this.ApellidoPa.HeaderText = "ApellidoPaterno";
            this.ApellidoPa.MinimumWidth = 6;
            this.ApellidoPa.Name = "ApellidoPa";
            this.ApellidoPa.Width = 125;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "ApellidoMaterno";
            this.ApellidoMaterno.MinimumWidth = 6;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Width = 125;
            // 
            // DniAlu
            // 
            this.DniAlu.HeaderText = "DNI";
            this.DniAlu.MinimumWidth = 6;
            this.DniAlu.Name = "DniAlu";
            this.DniAlu.Width = 125;
            // 
            // CorreoAlu
            // 
            this.CorreoAlu.HeaderText = "Correo";
            this.CorreoAlu.MinimumWidth = 6;
            this.CorreoAlu.Name = "CorreoAlu";
            this.CorreoAlu.Width = 125;
            // 
            // fech
            // 
            this.fech.HeaderText = "Fecha Nacimiento";
            this.fech.MinimumWidth = 6;
            this.fech.Name = "fech";
            this.fech.Width = 125;
            // 
            // GradoAlu
            // 
            this.GradoAlu.HeaderText = "Estado";
            this.GradoAlu.MinimumWidth = 6;
            this.GradoAlu.Name = "GradoAlu";
            this.GradoAlu.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 384);
            this.Controls.Add(this.Titulolabel6);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.Atrasbutton1);
            this.Controls.Add(this.Salitbutton1);
            this.Controls.Add(this.DNItextBox1);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListarAlumnos";
            this.Text = "Listar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulolabel6;
        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.Button Atrasbutton1;
        private System.Windows.Forms.Button Salitbutton1;
        private System.Windows.Forms.TextBox DNItextBox1;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoAlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fech;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradoAlu;
    }
}