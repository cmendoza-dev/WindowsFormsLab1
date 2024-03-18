using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2
{
    public class Pago
    {
        public string Empleado { get; set; }
        public string Categoria { get; set; }
        public double Basico { get; set; }
        public double Bonificacion { get; set; }
        
        public double Remuneracion()
        {
            return Basico + Bonificacion;
        }

    }
}
