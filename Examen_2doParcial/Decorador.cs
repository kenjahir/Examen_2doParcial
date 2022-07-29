using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_DECORADOR
{
    class Decorador : BaseHelado
    {
        protected BaseHelado orden;
        public Decorador(BaseHelado orden)
        {
            this.orden = orden;
        }
        public override double CalcularTotalPrecioOrden()
        {
            Console.WriteLine("Cálculo del precio total de los helados desde la clase decorador");
            return orden.CalcularTotalPrecioOrden();
        }
    }

}