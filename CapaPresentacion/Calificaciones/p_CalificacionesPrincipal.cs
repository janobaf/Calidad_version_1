using CapaPresentacion.Calificaciones;
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
    public partial class p_CalificacionesPrincipal : Form
    {
        public p_CalificacionesPrincipal()
        {
            InitializeComponent();
        }

        private void iconButtonListarCalificaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalificacionesList listado = new CalificacionesList();
            listado.Show();
        }

        private void iconButtonModificarCalificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Calificaciones modificar = new Modificar_Calificaciones();
            modificar.Show();
        }

        private void iconButtonRegistrarCalificaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar_Calificaciones registrar = new Registrar_Calificaciones();
            registrar.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
