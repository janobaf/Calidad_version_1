using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Horario
{
    public   class E_Horario
    {
        public int Hora_Id { get; set; }
        public int Hor_Curso_ID { get; set; }
        public string Hor_Seleccion { get; set; }
        public DateTime Hor_FechInscripcion     { get; set; }

    }
}
