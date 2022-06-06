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
            this.Titulolabel6.Location = new System.Drawing.Point(379, 11);
            this.Titulolabel6.Name = "Titulolabel6";
            this.Titulolabel6.Size = new System.Drawing.Size(174, 32);
            this.Titulolabel6.TabIndex = 59;
            this.Titulolabel6.Text = "Listar Alumno";
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Buscarbutton1.Location = new System.Drawing.Point(558, 74);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(95, 34);
            this.Buscarbutton1.TabIndex = 57;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click);
            // 
            // Atrasbutton1
            // 
            this.Atrasbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atrasbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Atrasbutton1.Location = new System.Drawing.Point(289, 232);
            this.Atrasbutton1.Name = "Atrasbutton1";
            this.Atrasbutton1.Size = new System.Drawing.Size(111, 44);
            this.Atrasbutton1.TabIndex = 56;
            this.Atrasbutton1.Text = "Atras";
            this.Atrasbutton1.UseVisualStyleBackColor = true;
            this.Atrasbutton1.Click += new System.EventHandler(this.Atrasbutton1_Click);
            // 
            // DNItextBox1
            // 
            this.DNItextBox1.Location = new System.Drawing.Point(145, 75);
            this.DNItextBox1.Name = "DNItextBox1";
            this.DNItextBox1.Size = new System.Drawing.Size(397, 20);
            this.DNItextBox1.TabIndex = 48;
            this.DNItextBox1.TextChanged += new System.EventHandler(this.DNItextBox1_TextChanged);
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(70, 74);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(40, 21);
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 88);
            this.dataGridView1.TabIndex = 46;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // ApellidoPa
            // 
            this.ApellidoPa.HeaderText = "ApellidoPaterno";
            this.ApellidoPa.Name = "ApellidoPa";
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "ApellidoMaterno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            // 
            // DniAlu
            // 
            this.DniAlu.HeaderText = "DNI";
            this.DniAlu.Name = "DniAlu";
            // 
            // CorreoAlu
            // 
            this.CorreoAlu.HeaderText = "Correo";
            this.CorreoAlu.Name = "CorreoAlu";
            // 
            // fech
            // 
            this.fech.HeaderText = "Fecha Nacimiento";
            this.fech.Name = "fech";
            // 
            // GradoAlu
            // 
            this.GradoAlu.HeaderText = "Estado";
            this.GradoAlu.Name = "GradoAlu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 312);
            this.Controls.Add(this.Titulolabel6);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.Atrasbutton1);
            this.Controls.Add(this.DNItextBox1);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
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