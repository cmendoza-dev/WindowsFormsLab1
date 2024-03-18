using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2
{
   public class ONP : Pago
    {
        public double Descuento() {
            return Remuneracion() * 0.13;
        }

        public double Neto()
        {
            return Remuneracion() - Descuento();
        }

    }
}
