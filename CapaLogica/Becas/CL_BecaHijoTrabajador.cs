using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Becas;
using CapaEntidad.Alumno;
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

        public E_Alumno retornarAlumno(String DNI)
        {
            E_Alumno a = new E_Alumno();
            a = CD_BecaHijoTrabajador.Instancia.Mostrar(DNI);
            return a;
        }

        #endregion metodos
    }
}
