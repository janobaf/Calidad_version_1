namespace CapaPresentacion.Calificaciones
{
    partial class CalificacionesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalificacionesList));
            this.Salirbutton1 = new System.Windows.Forms.Button();
            this.dni_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ProfesordataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesordataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salirbutton1
            // 
            this.Salirbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salirbutton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Salirbutton1.Location = new System.Drawing.Point(525, 223);
            this.Salirbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Salirbutton1.Name = "Salirbutton1";
            this.Salirbutton1.Size = new System.Drawing.Size(127, 42);
            this.Salirbutton1.TabIndex = 125;
            this.Salirbutton1.Text = "Salir";
            this.Salirbutton1.UseVisualStyleBackColor = true;
            this.Salirbutton1.Click += new System.EventHandler(this.Salirbutton1_Click);
            // 
            // dni_txt
            // 
            this.dni_txt.Location = new System.Drawing.Point(412, 130);
            this.dni_txt.Margin = new System.Windows.Forms.Padding(4);
            this.dni_txt.Name = "dni_txt";
            this.dni_txt.Size = new System.Drawing.Size(289, 22);
            this.dni_txt.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 123;
            this.label6.Text = "DNI : ";
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Buscarbutton1.Location = new System.Drawing.Point(738, 119);
            this.Buscarbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(127, 42);
            this.Buscarbutton1.TabIndex = 122;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 41);
            this.label5.TabIndex = 121;
            this.label5.Text = "Listar Calificaciones";
            // 
            // ProfesordataGridView1
            // 
            this.ProfesordataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfesordataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProfesor,
            this.Nombre,
            this.ApellidoMaterno,
            this.AlumnoID,
            this.ProfesorID,
            this.final});
            this.ProfesordataGridView1.Location = new System.Drawing.Point(90, 468);
            this.ProfesordataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.ProfesordataGridView1.Name = "ProfesordataGridView1";
            this.ProfesordataGridView1.RowHeadersWidth = 51;
            this.ProfesordataGridView1.Size = new System.Drawing.Size(807, 241);
            this.ProfesordataGridView1.TabIndex = 120;
            // 
            // IDProfesor
            // 
            this.IDProfesor.HeaderText = "Calificaciones ID";
            this.IDProfesor.MinimumWidth = 6;
            this.IDProfesor.Name = "IDProfesor";
            this.IDProfesor.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Promedio";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Parcial 1";
            this.ApellidoMaterno.MinimumWidth = 6;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Width = 125;
            // 
            // AlumnoID
            // 
            this.AlumnoID.HeaderText = "Parcial 2";
            this.AlumnoID.MinimumWidth = 6;
            this.AlumnoID.Name = "AlumnoID";
            this.AlumnoID.Width = 125;
            // 
            // ProfesorID
            // 
            this.ProfesorID.HeaderText = "Trabajos";
            this.ProfesorID.MinimumWidth = 6;
            this.ProfesorID.Name = "ProfesorID";
            this.ProfesorID.Width = 125;
            // 
            // final
            // 
            this.final.HeaderText = "Examen Final";
            this.final.MinimumWidth = 6;
            this.final.Name = "final";
            this.final.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 726);
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // CalificacionesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 722);
            this.Controls.Add(this.Salirbutton1);
            this.Controls.Add(this.dni_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProfesordataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CalificacionesList";
            this.Text = "CalificacionesList";
            ((System.ComponentModel.ISupportInitialize)(this.ProfesordataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salirbutton1;
        private System.Windows.Forms.TextBox dni_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ProfesordataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn final;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}