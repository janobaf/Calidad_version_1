using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Calificaciones;


using CapaLogica.Calificaciones;


namespace CapaPresentacion.Calificaciones
{
    public partial class Modificar_Calificaciones : Form
    {
        private void enableButton()
        {
            //cambia false por true
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }
        private void disableButton()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }
        public Modificar_Calificaciones()
        {
            InitializeComponent();
            disableButton();
        }

        private void seteoEntidad(E_Calificaciones e_Calificaciones)
        {
            DNI_TXT.Text = Convert.ToString(e_Calificaciones.Califi_ID);  //Convert.ToInt32(e_Calificaciones.Califi_ID);
            PromediotextBox1.Text = Convert.ToString(e_Calificaciones.Califi_ID);
            Parcial1textBox2.Text = Convert.ToString(e_Calificaciones.Califi_ID);
            Parcial2textBox3.Text = Convert.ToString(e_Calificaciones.Califi_ID);
            TrabajostextBox4.Text = Convert.ToString(e_Calificaciones.Califi_ID);
            ExaFinaltextBox5.Text = Convert.ToString(e_Calificaciones.Califi_ID);
        }

        private void Continuarrbutton1_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;

            //click setear combobox
            E_Calificaciones e_Calificaciones = new E_Calificaciones();
            e_Calificaciones = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);

            if (e_Calificaciones != null) { 
                seteoEntidad(e_Calificaciones);
                enableButton();
            } else {
                MessageBox.Show("no exist dni");
            }
        }

        private void Salirbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //modelo de lo que vas a repetir, esto es parcial 1
        private void button1_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            E_Calificaciones e_Calificaciones = new E_Calificaciones();

            e_Calificaciones = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);
            e_Calificaciones.Califi_Parcial1 = float.Parse(Parcial1textBox2.Text);

            CL_calificaciones.Instancia.modificar_calificacion_parcial1(e_Calificaciones, dni);

            MessageBox.Show("Registro exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            E_Calificaciones e_Calificaciones = new E_Calificaciones();

            e_Calificaciones = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);
            e_Calificaciones.Califi_Parcial2 = float.Parse(Parcial2textBox3.Text);

            CL_calificaciones.Instancia.modificar_calificacion_parcial12(e_Calificaciones, dni);

            MessageBox.Show("Registro exito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            E_Calificaciones e_Calificaciones = new E_Calificaciones();

            e_Calificaciones = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);
            e_Calificaciones.Califi_Trabajos = float.Parse(TrabajostextBox4.Text);

            CL_calificaciones.Instancia.modificar_calificacion_parcial12(e_Calificaciones, dni);

            MessageBox.Show("Registro exito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            E_Calificaciones e_Calificaciones = new E_Calificaciones();

            e_Calificaciones = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);
            e_Calificaciones.Califi_Final = float.Parse(ExaFinaltextBox5.Text);

            CL_calificaciones.Instancia.modificar_calificacion_parcial12(e_Calificaciones, dni);

            MessageBox.Show("Registro exito");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            E_Calificaciones e_Calificaciones = new E_Calificaciones();

            e_Calificaciones = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);
            e_Calificaciones.Califi_Promedio = float.Parse(PromediotextBox1.Text);

            CL_calificaciones.Instancia.modificar_calificacion_parcial12(e_Calificaciones, dni);

            MessageBox.Show("Registro exito");
        }
    }
}



