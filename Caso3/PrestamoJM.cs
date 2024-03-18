using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso3
{
    public class PrestamoJM: Prestamo
    {
        public string TipoMoneda { get; set; }


        public override double PagoMensual()
        {
            if (TipoMoneda == "Soles")
            {
                InteresMensual = 0.028;
            }
            else if (TipoMoneda == "Dólares")
            {
                InteresMensual = 0.03;
            }
            else if (TipoMoneda == "Euros") 
            { 
                InteresMensual = 0.025; 
            }else
            {
                InteresMensual = 0.03;
            }

            return base.PagoMensual();

        }

    }
}
