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
    public partial class Registro_Alumno : Form
    {
        public Registro_Alumno()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void Continuarbutton1_Click(object sender, EventArgs e)
        {
            string nombre = NombretextBox1.Text;
            string apellido_paterno = ApePaternotextBox1.Text;
            string apellido_materno = ApeMaternotextBox1.Text;
            string dirreccion = DirecciontextBox1.Text;
            DateTime fecha_nacimiento = DateTime.Parse(fechaNacidateTimePicker1.Text);
            
            string dni = DNItextBox1.Text;
            string correo = CorreotextBox1.Text;
            string telefono = TelefonotextBox1.Text;
            string nombre_apoderado = nomApoderadotextBox1.Text;
            string apellido_paterno_apoderado = apPaternoApoderadotextBox1.Text;
            string apellido_materno_apoderado = ApeMaternoApoderadotextBox1.Text;
            string estado = EstadotextBox1.Text;
            if (nombre != " " && apellido_paterno != " " && apellido_materno != "" && dni != " ")
            {
                if (dni.Length==8 )
                {
                    var esnumero = int.TryParse(dni, out int n);
                    if(esnumero == true)
                    {
                        E_Alumno alumno = new E_Alumno();
                        alumno.Alumn_nombre = nombre;
                        alumno.Alumn_ApellidoMaterno = apellido_materno;
                        alumno.Alumn_ApellidoPaterno = apellido_paterno;
                        alumno.Alumn_Direccion = dirreccion;
                        alumno.Alumn_Fechnaci = fecha_nacimiento;
                        alumno.Alumn_dni = dni;
                        alumno.Alum_Correo = correo;
                        alumno.Alum_Telefono = telefono;
                        alumno.Alumn_ApoderadoNombre = nombre_apoderado;
                        alumno.Alumn_ApoderadoApellido = apellido_paterno_apoderado;
                        alumno.Alumn_ApoderadoMaterno = apellido_materno_apoderado;
                        alumno.Alumn_Estado = estado;
                        alumno.Alumn_fechInscripcion = DateTime.Parse(Fecha_inscripcion.Text);
                        alumno.Alumn_Tipo = Tipo_txt.Text;
                        if (L_Alumno.Instancia.crear_alumno(alumno))
                            MessageBox.Show("Creado con exito ");
                        else
                            MessageBox.Show("ERROR EN LA CREACION", "ERROR");
                    }
                }
            }
            else
                MessageBox.Show("FALTAN DATOS","ERROR");
        MessageBox.Show("entre");
        }
    }
}
