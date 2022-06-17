namespace CapaPresentacion
{
    partial class p_CalificacionesPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.iconButtonRegistrarCalificaciones = new FontAwesome.Sharp.IconButton();
            this.iconButtonModificarCalificacion = new FontAwesome.Sharp.IconButton();
            this.iconButtonListarCalificaciones = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButtonRegistrarCalificaciones
            // 
            this.iconButtonRegistrarCalificaciones.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.iconButtonRegistrarCalificaciones.IconColor = System.Drawing.Color.Green;
            this.iconButtonRegistrarCalificaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRegistrarCalificaciones.Location = new System.Drawing.Point(180, 243);
            this.iconButtonRegistrarCalificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonRegistrarCalificaciones.Name = "iconButtonRegistrarCalificaciones";
            this.iconButtonRegistrarCalificaciones.Size = new System.Drawing.Size(221, 59);
            this.iconButtonRegistrarCalificaciones.TabIndex = 4;
            this.iconButtonRegistrarCalificaciones.Text = "REGISTRAR CALIFICACIONES";
            this.iconButtonRegistrarCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonRegistrarCalificaciones.UseVisualStyleBackColor = true;
            this.iconButtonRegistrarCalificaciones.Click += new System.EventHandler(this.iconButtonRegistrarCalificaciones_Click);
            // 
            // iconButtonModificarCalificacion
            // 
            this.iconButtonModificarCalificacion.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.iconButtonModificarCalificacion.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButtonModificarCalificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonModificarCalificacion.Location = new System.Drawing.Point(471, 95);
            this.iconButtonModificarCalificacion.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonModificarCalificacion.Name = "iconButtonModificarCalificacion";
            this.iconButtonModificarCalificacion.Size = new System.Drawing.Size(221, 59);
            this.iconButtonModificarCalificacion.TabIndex = 5;
            this.iconButtonModificarCalificacion.Text = "MODIFICAR CALIFICACIONES";
            this.iconButtonModificarCalificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonModificarCalificacion.UseVisualStyleBackColor = true;
            this.iconButtonModificarCalificacion.Click += new System.EventHandler(this.iconButtonModificarCalificacion_Click);
            // 
            // iconButtonListarCalificaciones
            // 
            this.iconButtonListarCalificaciones.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButtonListarCalificaciones.IconColor = System.Drawing.Color.Green;
            this.iconButtonListarCalificaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonListarCalificaciones.Location = new System.Drawing.Point(180, 95);
            this.iconButtonListarCalificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonListarCalificaciones.Name = "iconButtonListarCalificaciones";
            this.iconButtonListarCalificaciones.Size = new System.Drawing.Size(221, 59);
            this.iconButtonListarCalificaciones.TabIndex = 6;
            this.iconButtonListarCalificaciones.Text = "LISTAR CALIFICACIONES POR DNI ";
            this.iconButtonListarCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonListarCalificaciones.UseVisualStyleBackColor = true;
            this.iconButtonListarCalificaciones.Click += new System.EventHandler(this.iconButtonListarCalificaciones_Click);
            // 
            // p_CalificacionesPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iconButtonRegistrarCalificaciones);
            this.Controls.Add(this.iconButtonModificarCalificacion);
            this.Controls.Add(this.iconButtonListarCalificaciones);
            this.Name = "p_CalificacionesPrincipal";
            this.Text = "p_CalificacionesPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButtonRegistrarCalificaciones;
        private FontAwesome.Sharp.IconButton iconButtonModificarCalificacion;
        private FontAwesome.Sharp.IconButton iconButtonListarCalificaciones;
    }
}