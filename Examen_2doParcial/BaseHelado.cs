using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_DECORADOR
{
    abstract class BaseHelado
    {
        //para que solo pueda ser usada por ella y sus hijas
        protected List<Heladeria> helado = new List<Heladeria>
        {
            new Heladeria{Sabor = "vainilla", Topping = "cereza", PrecioTopp = 50 , PrecioHel = 150},
            new Heladeria{Sabor = "Chocolate", Topping= "gomitas", PrecioTopp= 25, PrecioHel= 125},
            new Heladeria{Sabor = "Rompasa", Topping = "chocolate balnco", PrecioTopp= 40, PrecioHel= 140}
        };
        public abstract double CalcularTotalPrecioOrden();

    }
}