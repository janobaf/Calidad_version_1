using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Becas
{
    public class E_BecaParentesco
    {
        public int BecaParentesco_id { get; set; }
        public string BecaParentescoNombre { get; set; }
        public string BecaParentescoApellido_Paterno { get; set; }
        public string BecaParentescoApellido_Materno { get; set; }
    }
}
