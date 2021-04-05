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
            Cliente cliente = new Cliente("Eugenia", "Peronace");
            string nombreCompleto = cliente.ObtenerNombreCompleto();
            Console.WriteLine(nombreCompleto);

            Console.ReadKey();
        }
    }
}
