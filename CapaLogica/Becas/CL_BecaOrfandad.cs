using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Becas;
using CapaEntidad.Alumno;
namespace CapaLogica
{
    public class B_Orfandad
    {
        #region Singleton
        
        private static readonly B_Orfandad _instancia = new B_Orfandad();
        
        public static B_Orfandad Instancia
        {
            get { return B_Orfandad._instancia; }
        }

        #endregion
        #region metodos

        public E_Alumno retornarAlumno(String DNI)
        {
            E_Alumno a = new E_Alumno();
            a = CD_becaorfandad.Instancia.Mostrar(DNI);
            return a;
        }

        #endregion metodos
    }
}
