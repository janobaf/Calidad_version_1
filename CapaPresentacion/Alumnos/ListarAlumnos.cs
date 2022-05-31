using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad.Alumno;
namespace CapaPresentacion
{
    public partial class ListarAlumnos : Form
    {
      
        public ListarAlumnos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DNItextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            string aux = DNItextBox1.Text;
            if (aux != " " )
            {
                dataGridView1.Rows.Clear();
                E_Alumno alumno = new E_Alumno();
                if (L_Alumno.Instancia.listar_alumno_dni(aux) != null)
                    alumno = L_Alumno.Instancia.listar_alumno_dni(aux);
                  
                if (alumno !=null )
                {


                    dataGridView1.Rows.Add(alumno.Alumn_nombre,alumno.Alumn_ApellidoPaterno,alumno.Alumn_ApellidoMaterno,alumno.Alumn_dni,alumno.Alum_Correo,alumno.Alumn_Fechnaci,alumno.Alumn_Estado);
                }
            }
        }
    }
}

//listar_alumnos
