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
using CapaLogica.Becas;
namespace CapaPresentacion
{
    public partial class p_inscripcionprincipal : Form
    {
        public p_inscripcionprincipal()
        {
            InitializeComponent();
        }

      

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Alumno registro = new Registro_Alumno();
            registro.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Modificar_Alumno modificar = new Modificar_Alumno();
            modificar.Show();
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            ListarAlumnos listar = new ListarAlumnos();
            listar.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal form = new Principal();
            form.Show();
        }
    }
}
