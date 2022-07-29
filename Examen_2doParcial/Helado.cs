using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_DECORADOR
{
    class Helado : BaseHelado
    {
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine("Cálculo del precio de un helado con 1 toppin");
            return helado.Sum(x => x.PrecioHel) + 0.50;
        }
    }
}