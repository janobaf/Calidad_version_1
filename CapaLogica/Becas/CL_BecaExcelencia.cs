using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using CapaEntidad.Calificaciones;
using CapaDatos.Becas;
using CapaDatos.Calificaciones;
namespace CapaLogica.Becas
{
    public class CL_BecaExcelencia
    {

        #region Singleton

        private static readonly CL_BecaExcelencia _instancia = new CL_BecaExcelencia();

        public static CL_BecaExcelencia Instancia
        {
            get { return CL_BecaExcelencia._instancia; }
        }

        #endregion
        #region metodos

       public bool  Beca_exelencia (E_Alumno ea)
        {
            bool verificado = false;
            E_Calificaciones calificaciones = new E_Calificaciones();
            if(CD_Calificacines.Instancia.mostrar_calificaciones_dni(ea.Alumn_dni) !=null)
            {
                calificaciones = CD_Calificacines.Instancia.mostrar_calificaciones_dni(ea.Alumn_dni);
                if(calificaciones.Califi_Promedio>=16)
                {
                    if(CD_BecaExcelencia.Instancia.modificar_pension_alumno(ea.Alumn_dni))
                         verificado = true;
                }
            }
            return verificado;
        }

        #endregion metodos
    }
}
