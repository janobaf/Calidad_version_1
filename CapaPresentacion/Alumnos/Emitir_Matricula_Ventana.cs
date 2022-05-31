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
using CapaLogica.Pagos;
namespace CapaPresentacion.Pagos
{
    public partial class Emitir_Matricula_Ventana : Form
    {
        public Emitir_Matricula_Ventana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dni = dni_txt.Text;
            dni +="  ";
            if (L_Pagos.Instancia.mostrar_alumnos_NOpagaron() != null)
            {
                List<E_Alumno> alumno = L_Pagos.Instancia.mostrar_alumnos_NOpagaron();
                double aux;
                for (int i =0;i<alumno.Count;i++)
                {
                    if (alumno[i].Alumn_dni.Equals(dni))
                    {
                        Total_txt.Text = alumno[i].Alumn_Pension.ToString();
                        aux = alumno[i].Alumn_Pension;
                    }

                }
            }
         }
    }
}
