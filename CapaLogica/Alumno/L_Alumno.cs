using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Inscripcion;
using CapaEntidad.Alumno;
namespace CapaLogica
{
    public class L_Alumno
    {
        #region Singleton
        private static readonly L_Alumno _instancia = new L_Alumno();
        public static L_Alumno Instancia
        {
            get { return L_Alumno._instancia; }
        }
        #endregion
        #region metodos

        public bool crear_alumno(E_Alumno ea )
        {

            if (D_Crear_Inscripcion.Instancia.validar_dni(ea.Alumn_dni))
            {

                D_Crear_Inscripcion.Instancia.Crear_Alumnos_Inscripcion(ea);
                return true;

            }

             return false;

        }
        public bool modificar_alumno(E_Alumno ea)
        {

            if (D_Crear_Inscripcion.Instancia.validar_dni(ea.Alumn_dni))
            {

                D_Crear_Inscripcion.Instancia.Modificar_Alumnos_Inscripcion(ea);
                return true;

            }
            return false;
        }
        public List<E_Alumno> listar_alumnos()
        {
            List<E_Alumno> lista = new List<E_Alumno>(); ;

            return lista;

        }
        #endregion metodos

    }
}
