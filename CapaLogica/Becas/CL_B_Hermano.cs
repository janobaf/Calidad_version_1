using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Becas;
using CapaDatos.Inscripcion;
using CapaDatos.Calificaciones;
using CapaEntidad.Alumno;
using CapaEntidad.Calificaciones;
namespace CapaLogica.Becas
{
    public class CL_B_Hermano
    {
        #region Singleton

        private static readonly CL_B_Hermano _instancia = new CL_B_Hermano();

        public static CL_B_Hermano Instancia
        {
            get { return CL_B_Hermano._instancia; }
        }

        #endregion
        #region metodos
        public  bool existencia_persona(string dni)
        {
            if(D_Crear_Inscripcion.Instancia.validar_dni(dni))
                return true; 
            return false;
        }
        public bool beca_hermano(E_Alumno ea)
        {
            bool validar = this.existencia_persona(ea.Alumn_dni);

            if (validar)
            {   
                if (cd_beca_hermano.Instancia.Beca_hermanos(ea.Alumn_dni))
                {
                    E_Calificaciones aux = CD_Calificacines.Instancia.mostrar_calificaciones(ea.Alumn_dni);
                    if (aux != null)
                    {
                        if(aux.Califi_Promedio>=13)
                        {
                            if(cd_beca_hermano.Instancia.modificar_alumno(ea.Alumn_dni))
                                return true;
                        }
                    }
                }
            }

            return false;
        }
        #endregion metodos
    }
}
