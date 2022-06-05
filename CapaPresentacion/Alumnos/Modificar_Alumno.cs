using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Alumno;
using CapaLogica;
namespace CapaPresentacion.Inscripcion
{
    public partial class Modificar_Alumno : Form
    {
        public Modificar_Alumno()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            E_Alumno alumno = new E_Alumno();
            alumno = L_Alumno.Instancia.listar_alumno_dni(dni_txt.Text);
            if (alumno != null)
                Alumn_nombre.Text = alumno.Alumn_nombre;
            MessageBox.Show("entre");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            E_Alumno alumno = new E_Alumno();

            if (L_Alumno.Instancia.modificar_alumno(alumno))
                MessageBox.Show("Correcto");
            else
                MessageBox.Show("Incorrecto");
        }
    }
}
