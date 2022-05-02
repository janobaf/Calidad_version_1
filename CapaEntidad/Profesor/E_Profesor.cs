using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Profesor
{
    public  class E_Profesor
    {
        public int Prof_id { get; set; }
        public int Prof_Curso { get; set; }
        public string Prof_ApellidoPaterno { get; set; }
        public string Prof_ApellidoMaterno { get; set; }
        public string Prof_Direccion { get; set; }
        public string Prof_Tipo { get; set; }
        public DateTime Prof_FechNaci { get; set; }
        public string Prof_DNI{ get; set; }
        public string Prof_Estado { get; set; }


    }
}
