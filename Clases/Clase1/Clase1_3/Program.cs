using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        //HACER METODO QUE CUENTE LAS LETRAS
        static void Main(string[] args) //array de string como entrada de parametro
        {
            /* Console.WriteLine("Ingrese texto: ");
             Console.WriteLine(ContarLetras(Console.ReadLine(), 'a')); */

            Console.WriteLine("ingrese texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine("ingrese letra a contar: ");
            char letra = Console.ReadKey().KeyChar;

            //Program miPrograma= new Program(); //si no tuviera static el metodo, lo deja ser de clase, hay que instanciar.
            //miPrograma.ContarLetras();

            int cantidad = ContarLetras(texto, letra);
            Console.Clear();
            Console.WriteLine("\nLa cantidad ingresada es: {0}", cantidad);

            Console.ReadKey();
        }

        //recorre caracteres de nuestro texto y si encuentra una 'a' la retorna
        static int ContarLetras(string texto, char letra)
        {
            int aux = 0;

            for (int i = 0; i < texto.Length; i++)

                if (texto.ToCharArray()[i] == letra)
                    aux = aux + 1;

            return aux;
        }

        static int ContarLetras2(string texto, char letra)
        {
            int aux = 0;
            foreach (char item in texto.ToCharArray())

                if (Char.ToUpper(item) == Char.ToUpper(letra))
                    aux = aux + 1;

            return aux;
        }
        
        static int ContarLetras3(string texto, char letra)
        {
            int i = 0;
            int aux = 0;

            while (i < texto.Length)
            {
                if (texto.ToCharArray()[i] == letra)
                    aux = aux + 1;
            }

            return aux;
        }
    }
}