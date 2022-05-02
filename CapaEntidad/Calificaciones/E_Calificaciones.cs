using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Calificaciones
{
    public  class E_Calificaciones
    {
        public int Califi_ID { get; set; }
        public float Califi_Promedio { get; set; }
        public int Curso_id { get; set; }
        public float Califi_Parcial1 { get; set; }
        public float Califi_Parcial2 { get; set; }
        public float Califi_Trabajos { get; set; }
        public float Califi_Final { get; set; }

    }
}
