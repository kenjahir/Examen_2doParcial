using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_DECORADOR
{
    class Helado1 : Decorador
    {
        public Helado1(BaseHelado orden) : base(orden) { }
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine($"Cálculo del precio total en la clase {nameof(helado)}.");
            var HeladoPrecio = base.CalcularTotalPrecioOrden();
            Console.WriteLine("Adicionar el valor del toppin");
            return HeladoPrecio + 0.75;
        }
    }
}