using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Calificaciones;
using CapaPresentacion.InterfacesGraficas;
namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // para llamar a otro formulario
            // estas 3 lineas son para llamar
            this.Hide();
            // esto es una instancia apuntando a lformulario
            //NOMBRE FORMUARIO          CUALQUIER NOMBRE        =NEW NOMBRE FORMUALRIO
            p_inscripcionprincipal p_Inscripcionprincipal = new p_inscripcionprincipal();
            //ARRIBA: CUALQUIER NOMBRE.SHOW();
            p_Inscripcionprincipal.Show();
        }

        private void buttonCalificaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
           p_CalificacionesPrincipal p_calificacionPrincipal = new p_CalificacionesPrincipal();
            p_calificacionPrincipal.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
