using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorEntero = 25;

            Console.WriteLine("Ingrese un número: ");
            string numeroString = Console.ReadLine(); 

            //PARSEO
            int suma = valorEntero + int.Parse(numeroString);
            float numeroDecimal = (float)25.35;
            double numeroDec = 25.35;

            //CASTEO EXPLICITO
            int numeroEntero;
            numeroEntero = (int)numeroDecimal;
            

            Console.WriteLine($"La suma entre el núm que ingresó y 25 es: {suma}");
            Console.WriteLine($"El número decimal es: {numeroDecimal}");
            Console.WriteLine($"El numero entero es: {numeroEntero}");

            Console.ReadKey();
        }

    }
}
