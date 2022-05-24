using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Becas;
using CapaDatos.Alumnos;
using CapaEntidad.Alumno;
using CapaEntidad.Calificaciones;
using CapaDatos.Calificaciones;
namespace CapaLogica.Becas
{
    public class CL_BecaHijoTrabajador
    {

        #region Singleton

        private static readonly CL_BecaHijoTrabajador _instancia = new CL_BecaHijoTrabajador();

        public static CL_BecaHijoTrabajador Instancia
        {
            get { return CL_BecaHijoTrabajador._instancia; }
        }
                
        #endregion
        #region metodos
            
        public bool beca_hijo_trabajador(E_Alumno ea)
        {
            bool validar = false;
            if(CD_Alumno.Instancia.validar_dni(ea.Alumn_dni))
            {
                if(CD_BecaHijoTrabajador.Instancia.Validar_hijo_docente(ea.Alumn_dni))
                {
                    E_Calificaciones aux = CD_Calificacines.Instancia.mostrar_calificaciones(ea.Alumn_dni);
                    if(aux != null)
                    {
                        if(aux.Califi_Promedio>=13)
                        {
                            if (CD_BecaHijoTrabajador.Instancia.modificar_pension(ea.Alumn_dni)) validar = true;
                        }
                    }
                }
            }
            return validar;
        }

        #endregion metodos
    }
}
