using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso3
{
    public class Prestamo
    {
        public string Cliente { get; set; }
        public double MontoSolicitado { get; set; }
        public int TiempoDuracion { get; set; }
        public double InteresMensual { get; set; }


        public virtual double PagoMensual()
        {
            double tasaInteresMensual = InteresMensual; // Convertir la tasa de interés anual a mensual
            double factor = Math.Pow(1 + tasaInteresMensual, TiempoDuracion);
            double cuotaMensual = (MontoSolicitado * tasaInteresMensual * factor) / (factor - 1);
            return Math.Round(cuotaMensual, 2);
        }

    }
}
