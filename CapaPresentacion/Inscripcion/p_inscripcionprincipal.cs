using CapaPresentacion.Inscripcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class p_inscripcionprincipal : Form
    {
        private Form currentChildForm;
        public p_inscripcionprincipal()
        {
            InitializeComponent();
        }

        private void openchildform(Form childForm)
        {
            if(currentChildForm != null) 
                currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(childForm);
            panelFormularios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openchildform(new Crear_inscripcion());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openchildform(new Modificar_Alumno());

        }
    }
}
