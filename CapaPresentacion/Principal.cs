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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            p_inscripcionprincipal p_Inscripcionprincipal = new p_inscripcionprincipal();
            p_Inscripcionprincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Becas_Por_Exelencia p_Inscripcionprincipal = new Becas_Por_Exelencia();
            p_Inscripcionprincipal.Show();
        }
    }
}
