using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Alumnos;
using CapaEntidad.Curso;
namespace CapaLogica.Curso
{
    public class CL_Curso
    {
        public bool crear_Curso(E_Curso curso)
        {

            return CD_Curso.Instancia.Crear_curso(curso) == true ? true : false;
        }

        public List<E_Curso> listar_cursos()
        {
            return CD_Curso.Instancia.listar_cursos();
        }

        public bool Enalazar_Curso_Alumno(string dni, int Curso_ID)
        {
            return CD_Curso.Instancia.Enalazar_Curso_Alumno(dni, Curso_ID) == true ? true : false;
        }
    }
}
