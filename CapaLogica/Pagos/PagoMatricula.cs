using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Alumnos;
using CapaDatos.Pagos;
namespace CapaLogica.Pagos
{
    public class PagoMatricula
    {

        public float pagoM(float pension)
        {
            float pagomatricula=200;
      
            return pagomatricula;
        }
        public bool pago_matricula(E_Alumno ea)
        {
            bool validar = false;
            if (CD_Alumno.Instancia.mostrar_alumno_dni(ea.Alumn_dni) != null)
            {
                E_Alumno alumno = new E_Alumno();
                alumno = CD_Alumno.Instancia.mostrar_alumno_dni(ea.Alumn_dni);
                if (alumno.Alumn_Estado == "FALSO")
                {
                    if (CD_Pagos.Instancia.modificar_pago(ea.Alumn_dni))
                        validar = true;
                }
            }
            return validar;
        }
        public List<E_Alumno> mostrar_alumnos_si_matricula()
        {
            List<E_Alumno> alumno = new List<E_Alumno>();
            if (CD_Pagos.Instancia.mostrar_alumnos("TRUE") != null)
            {
                alumno = CD_Pagos.Instancia.mostrar_alumnos("TRUE");

            }
            if (alumno != null) return alumno;
            return null;
        }
        public List<E_Alumno> mostrar_alumnos_no_matricula()
        {
            List<E_Alumno> alumno = new List<E_Alumno>();
            if (CD_Pagos.Instancia.mostrar_alumnos("FALSE") != null)
            {
                alumno = CD_Pagos.Instancia.mostrar_alumnos("true");

            }
            if (alumno != null) return alumno;
            return null;
        }






    }
}
