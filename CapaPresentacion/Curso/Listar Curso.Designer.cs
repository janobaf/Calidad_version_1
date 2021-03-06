namespace CapaPresentacion.InterfacesGraficas
{
    partial class Listar_Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar_Curso));
            this.ProfesordataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CursoIDtextBox1 = new System.Windows.Forms.TextBox();
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.Modificarbutton1 = new System.Windows.Forms.Button();
            this.Eliminarbutton2 = new System.Windows.Forms.Button();
            this.Atrasbutton2 = new System.Windows.Forms.Button();
            this.Salirbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesordataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfesordataGridView1
            // 
            this.ProfesordataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfesordataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProfesor,
            this.Nombre,
            this.ApellidoPa,
            this.ApellidoMaterno,
            this.AlumnoID,
            this.ProfesorID});
            this.ProfesordataGridView1.Location = new System.Drawing.Point(54, 222);
            this.ProfesordataGridView1.Name = "ProfesordataGridView1";
            this.ProfesordataGridView1.Size = new System.Drawing.Size(647, 168);
            this.ProfesordataGridView1.TabIndex = 99;
            // 
            // IDProfesor
            // 
            this.IDProfesor.HeaderText = "ID Curso";
            this.IDProfesor.Name = "IDProfesor";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Curso";
            this.Nombre.Name = "Nombre";
            // 
            // ApellidoPa
            // 
            this.ApellidoPa.HeaderText = "Estado";
            this.ApellidoPa.Name = "ApellidoPa";
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Fecha de Inscripcion";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            // 
            // AlumnoID
            // 
            this.AlumnoID.HeaderText = "Alumno ID";
            this.AlumnoID.Name = "AlumnoID";
            // 
            // ProfesorID
            // 
            this.ProfesorID.HeaderText = "Profesor ID";
            this.ProfesorID.Name = "ProfesorID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 101;
            this.label5.Text = "Listar Cursos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 102;
            this.label6.Text = "Curso ID:";
            // 
            // CursoIDtextBox1
            // 
            this.CursoIDtextBox1.Location = new System.Drawing.Point(341, 74);
            this.CursoIDtextBox1.Name = "CursoIDtextBox1";
            this.CursoIDtextBox1.Size = new System.Drawing.Size(218, 20);
            this.CursoIDtextBox1.TabIndex = 107;
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Buscarbutton1.Location = new System.Drawing.Point(93, 154);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(95, 34);
            this.Buscarbutton1.TabIndex = 112;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            // 
            // Modificarbutton1
            // 
            this.Modificarbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificarbutton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Modificarbutton1.Location = new System.Drawing.Point(355, 154);
            this.Modificarbutton1.Name = "Modificarbutton1";
            this.Modificarbutton1.Size = new System.Drawing.Size(95, 34);
            this.Modificarbutton1.TabIndex = 113;
            this.Modificarbutton1.Text = "Modificar";
            this.Modificarbutton1.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton2
            // 
            this.Eliminarbutton2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Eliminarbutton2.Location = new System.Drawing.Point(628, 154);
            this.Eliminarbutton2.Name = "Eliminarbutton2";
            this.Eliminarbutton2.Size = new System.Drawing.Size(95, 34);
            this.Eliminarbutton2.TabIndex = 114;
            this.Eliminarbutton2.Text = "Eliminar";
            this.Eliminarbutton2.UseVisualStyleBackColor = true;
            // 
            // Atrasbutton2
            // 
            this.Atrasbutton2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atrasbutton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Atrasbutton2.Location = new System.Drawing.Point(674, 404);
            this.Atrasbutton2.Name = "Atrasbutton2";
            this.Atrasbutton2.Size = new System.Drawing.Size(95, 34);
            this.Atrasbutton2.TabIndex = 115;
            this.Atrasbutton2.Text = "Atras";
            this.Atrasbutton2.UseVisualStyleBackColor = true;
            // 
            // Salirbutton1
            // 
            this.Salirbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salirbutton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Salirbutton1.Location = new System.Drawing.Point(564, 404);
            this.Salirbutton1.Name = "Salirbutton1";
            this.Salirbutton1.Size = new System.Drawing.Size(95, 34);
            this.Salirbutton1.TabIndex = 119;
            this.Salirbutton1.Text = "Salir";
            this.Salirbutton1.UseVisualStyleBackColor = true;
            // 
            // Listar_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salirbutton1);
            this.Controls.Add(this.Atrasbutton2);
            this.Controls.Add(this.Eliminarbutton2);
            this.Controls.Add(this.Modificarbutton1);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.CursoIDtextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProfesordataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Listar_Curso";
            this.Text = "Listar_Curso";
            ((System.ComponentModel.ISupportInitialize)(this.ProfesordataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProfesordataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CursoIDtextBox1;
        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.Button Modificarbutton1;
        private System.Windows.Forms.Button Eliminarbutton2;
        private System.Windows.Forms.Button Atrasbutton2;
        private System.Windows.Forms.Button Salirbutton1;
    }
}