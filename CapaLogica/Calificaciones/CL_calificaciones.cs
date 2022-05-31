using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Calificaciones;
using CapaEntidad.Calificaciones;
namespace CapaLogica.Calificaciones
{
    public class CL_calificaciones
    {
        #region Singleton

        private static readonly CL_calificaciones _instancia = new CL_calificaciones();

        public static CL_calificaciones Instancia
        {
            get { return CL_calificaciones._instancia; }
        }

        #endregion
        #region metodos
        public bool crear_calificaciones(E_Calificaciones calificaciones , string dni)
        {
            return CD_Calificacines.Instancia.crear_calificaciones(dni, calificaciones) == true ? true : false;
        }

        public E_Calificaciones mostrar_calificaciones_dni(string dni)
        {
            return CD_Calificacines.Instancia.mostrar_calificaciones_dni(dni);
        }
        public bool modificar_calificacion_parcial1(E_Calificaciones calificaciones, string dni)
        {
            return CD_Calificacines.Instancia.modificar_calificacion_parcial1(calificaciones,dni) == true ? true : false;
        }

        public bool modificar_calificacion_parcial12(E_Calificaciones calificaciones, string dni)
        {
            return CD_Calificacines.Instancia.modificar_calificacion_parcial2(calificaciones, dni) == true ? true : false;
        }
        public bool modificar_calificacion_Trabajos(E_Calificaciones calificaciones, string dni)
        {
            return CD_Calificacines.Instancia.modificar_calificacion_Trabajos(calificaciones, dni) == true ? true : false;
        }

        public bool modificar_calificacion_Final(E_Calificaciones calificaciones, string dni)
        {
            return CD_Calificacines.Instancia.modificar_calificacion_Final(calificaciones, dni) == true ? true : false;
        }

        public bool modificar_calificacion_Promedio(E_Calificaciones calificaciones, string dni)
        {
            return CD_Calificacines.Instancia.modificar_calificacion_Promedio(calificaciones, dni) == true ? true : false;
        }
        #endregion metodos
    }
}
