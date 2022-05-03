﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Pagos
{
    public partial class Ventana_principal_Pagos : Form
    {
        private Form currentChildForm;

        public Ventana_principal_Pagos()
        {
            InitializeComponent();
        }
        private void openchildform(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Contenido.Controls.Add(childForm);
            panel_Contenido.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openchildform(new Emitir_Pension_Ventana());

        }
    }
}
