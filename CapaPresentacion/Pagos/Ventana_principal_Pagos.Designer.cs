namespace CapaPresentacion.Pagos
{
    partial class Ventana_principal_Pagos
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
            this.Panerl_Formulario = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel_Contenido = new System.Windows.Forms.Panel();
            this.Panerl_Formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panerl_Formulario
            // 
            this.Panerl_Formulario.Controls.Add(this.iconButton3);
            this.Panerl_Formulario.Controls.Add(this.iconButton2);
            this.Panerl_Formulario.Controls.Add(this.iconButton1);
            this.Panerl_Formulario.Location = new System.Drawing.Point(2, 1);
            this.Panerl_Formulario.Name = "Panerl_Formulario";
            this.Panerl_Formulario.Size = new System.Drawing.Size(799, 91);
            this.Panerl_Formulario.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButton3.IconColor = System.Drawing.Color.Green;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(508, 26);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(114, 53);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Buscar Pago";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton2.IconColor = System.Drawing.Color.Green;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(232, 26);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(133, 53);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Emitir Matricula";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(20, 26);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(130, 53);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Emitir Pension";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel_Contenido
            // 
            this.panel_Contenido.Location = new System.Drawing.Point(3, 95);
            this.panel_Contenido.Name = "panel_Contenido";
            this.panel_Contenido.Size = new System.Drawing.Size(797, 357);
            this.panel_Contenido.TabIndex = 1;
            // 
            // Ventana_principal_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Contenido);
            this.Controls.Add(this.Panerl_Formulario);
            this.Name = "Ventana_principal_Pagos";
            this.Text = "Ventana_principal_Pagos";
            this.Panerl_Formulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panerl_Formulario;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel_Contenido;
    }
}