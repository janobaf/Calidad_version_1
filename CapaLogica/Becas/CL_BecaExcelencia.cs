using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using CapaDatos.Becas;
namespace CapaLogica.Becas
{
    internal class CL_BecaExcelencia
    {

        #region Singleton

        private static readonly CL_BecaExcelencia _instancia = new CL_BecaExcelencia();

        public static CL_BecaExcelencia Instancia
        {
            get { return CL_BecaExcelencia._instancia; }
        }

        #endregion
        #region metodos

        public E_Alumno retornarAlumno(String DNI)
        {
            E_Alumno a = new E_Alumno();
            a = CD_BecaHijoTrabajador.Instancia.Mostrar(DNI);
            return a;
        }

        #endregion metodos
    }
}
