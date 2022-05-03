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
    public partial class Crear_inscripcion : Form
    {
        public Crear_inscripcion()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            E_Alumno alumno_datos = new E_Alumno();
            bool validar = false;
            string alum_nombre = Alumn_nombre.Text;
            string alum_apellidoPaterno = Alumn_apellidopaterno.Text;
            string alum_apellidoMaterno = Alumn_apellidoMaterno.Text;
            string alumn_dni = Alumn_DNI.Text;
            string alumn_direccion = Alumn_Direccion.Text;
            string alumn_tipo = Alumn_Tipo.Text;
            string alumn_estado = Alumn_Estado.Text;
            string alumn_grado = Alumn_Grado.Text;
            string alumn_nombre_apoderado = Alumn_nombreApoderado.Text;
            string alumn_apellido_paterno_apoderado = Alumn_ApellidoPaternoapoderado.Text;
            string alumn_apellido_materno_apoderado = Alumn_ApellidoMaternoApoderado.Text;
            if (alum_nombre == "" || alum_apellidoPaterno == "" || alum_apellidoMaterno == "" || alumn_dni == "" || alumn_direccion == "" || alumn_tipo == "" || alumn_estado == "" || alumn_grado == "" || alumn_nombre_apoderado == "" || alumn_apellido_paterno_apoderado == "" || alumn_apellido_materno_apoderado == "")

            {
                MessageBox.Show("error sin contenido");
                validar = true;
            }

            if (alumn_dni.Length != 8)
            {

                MessageBox.Show("error el dni no tiene 8 digitos");
                validar = true;
            }

            if(validar == false)
            {
                alumno_datos.Alumn_nombre = alum_nombre;
                alumno_datos.Alumn_ApellidoPaterno = alum_apellidoPaterno;
                alumno_datos.Alumn_ApellidoMaterno = alum_apellidoMaterno;
                alumno_datos.Alumn_dni = alumn_dni;
                alumno_datos.Alumn_Direccion = alumn_direccion;
                alumno_datos.Alumn_Tipo = alumn_tipo;
                alumno_datos.Alumn_Estado = alumn_estado;
                alumno_datos.Alumn_Grado = alumn_grado;
                alumno_datos.Alumn_ApoderadoNombre = alumn_nombre_apoderado;
                alumno_datos.Alumn_ApoderadoApellido = alumn_apellido_paterno_apoderado;
                alumno_datos.Alumn_ApoderadoMaterno = alumn_apellido_materno_apoderado;
                alumno_datos.Alumn_Fechnaci = Alumn_FechaNacimiento.Value;
                alumno_datos.Alumn_fechInscripcion = Alumn_FechaInscripcion.Value;


                L_Alumno.Instancia.crear_alumno(alumno_datos);
            }
        }
    }
}
