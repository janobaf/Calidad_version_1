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
        public Modificar_Calificaciones()
        {
            InitializeComponent();
        }

        private E_Calificaciones seteoEntidad(E_Calificaciones e_Calificaciones)
        {
            //e_Calificaciones le comenzamos a llenar de valores

            //e_Calificaciones con el "." podemos acceder a todos los atributos que tenga get. esto se ve en la capa entidad
            e_Calificaciones.Califi_ID = Int32.Parse(DNI_TXT.Text);
            e_Calificaciones.Califi_Promedio = float.Parse(PromediotextBox1.Text);//Int32.Parse(PromediotextBox1.Text);//verifica el tipo
            e_Calificaciones.Califi_Parcial1 = float.Parse(Parcial1textBox2.Text);
            e_Calificaciones.Califi_Parcial2 = float.Parse(Parcial2textBox3.Text);
            e_Calificaciones.Califi_Trabajos = float.Parse(TrabajostextBox4.Text);
            e_Calificaciones.Califi_Final = float.Parse(ExaFinaltextBox5.Text);
            //ahora deber ver todos los campos del form y llenarlo en el objeto "e_Calificaciones" mediante el "." acceder y ver


            // retornamos el "e_Calificaciones" con valores ya no vacio
            return e_Calificaciones;
        }

        private void Continuarrbutton1_Click(object sender, EventArgs e)
        {

            // creamos mediante la instanciacion un "e_Calificaciones" para mandar al metodo "seteo" que nos retornara lo que enviamos
            // con valores
            E_Calificaciones e_Calificaciones = new E_Calificaciones();

            //llamamos al metod y le enviamos e_Calificaciones para que le llene
            seteoEntidad(e_Calificaciones);

            //ahora ya esta lleno e_Calificaciones

            //declare un dni porque el metodo crear quiere necesita un dni
            string dni = DNI_TXT.Text;
            CL_calificaciones.Instancia.crear_calificaciones(e_Calificaciones, dni);

        }

        private void Salirbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



