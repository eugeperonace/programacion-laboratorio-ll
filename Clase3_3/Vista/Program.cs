using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"La cantidad de ruedas es: {Auto.GetCantidadRuedas()}");

            Auto auto = new Auto("Clio", "Mio");
            Console.WriteLine(auto.GetAuto());

            Auto.SetCantidadRuedas(8);
            Console.WriteLine($"Ahora el auto tiene: {Auto.GetCantidadRuedas()} ruedas.");

            Console.ReadKey();

        }
    }
}