using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;

namespace CapaLogica.Pagos
{
    public class L_Pagos
    {
        public float pagos(int nota, float pension)
        {
            float pago_pension = 0;

            if (nota >=16)
            {
                pago_pension = (float)(pension * 0.5);
            }
            return pago_pension;
        }

    }
}
