using System;

namespace EXAMEN_DECORADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            var HeladoRegular = new HeladoRegular();
            Console.WriteLine(HeladoRegular.CalcularTotalPrecioOrden());
            Console.WriteLine();

            var Helado = new Helado();
            Console.WriteLine(Helado.CalcularTotalPrecioOrden());
            Console.WriteLine();

            var Helado1 = new Helado1(Helado);
            Console.WriteLine(Helado1.CalcularTotalPrecioOrden());
            Console.WriteLine();
        }
    }
}
