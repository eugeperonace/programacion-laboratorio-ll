using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args) //array de string como entrada de parametro
        {

            Console.Write("Ingrese un número float: ");
            string dato = Console.ReadLine();

            float
                valorFloat = float.Parse(dato);

            Console.WriteLine($"Valor igresado: {valorFloat}");
            Console.Write("Valor sin la parte entera: ");
            Console.WriteLine(QuitarParteEntera(valorFloat));

            Console.ReadKey();
        }

        public static float QuitarParteEntera(float numero) //retorta un float
        {
            //CASTEO A ENTERO
            int numeroEntero = (int)numero; //solo queda parte entera, no retorna dec
            //RESTA EL ENTERO
            numero = numero - (int)numero; //numero = numero - numeroEntero; 
            return numero;
        }
    }
}

