using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_DECORADOR
{
    class HeladoRegular : BaseHelado
    {
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine("el valor del helado normal es ");
            return helado.Sum(x => x.PrecioHel);
        }
    }
}