using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Alumno
{
    public  class E_Alumn_Beca
    {
        public int Alumn_Beca_ID { get; set; }
        public string Alumn_Beca_NombreBeca{ get; set; }
        public int Alumn_ID { get; set; }
        public string Alumn_Beca_Descripcion { get; set; }
        public DateTime Alumn_Beca_FechBeca { get; set; }
        public float Alumn_Beca_Descuento { get; set; }

    }
}
