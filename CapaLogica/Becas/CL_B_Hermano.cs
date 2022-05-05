using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Becas;
using CapaEntidad.Alumno;
namespace CapaLogica.Becas
{
    internal class CL_B_Hermano
    {
        #region Singleton

        private static readonly CL_B_Hermano _instancia = new CL_B_Hermano();

        public static CL_B_Hermano Instancia
        {
            get { return CL_B_Hermano._instancia; }
        }

        #endregion
        #region metodos

        public E_Alumno retornarAlumno(String DNI)
        {
            E_Alumno a = new E_Alumno();
            a = cd_beca_hermano.Instancia.Mostrar(DNI); 
            return a;
        }

        #endregion metodos
    }
}
