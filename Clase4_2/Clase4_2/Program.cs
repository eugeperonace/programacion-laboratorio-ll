using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Eugenia", "Peronace", 39462617);
            Alumno alumno2 = new Alumno("Camila", "Gomez", 35854563, 15071507);

            int legajoAlumno2 = alumno2;     //uso la conversión implícita 
            long dniAlumno1 = (long)alumno1;

            if (alumno1 == alumno2)
            {
                Console.WriteLine($"El legajo del alumno: {alumno1} con número {alumno1.GetLegajo()} es igual al legajo del alumno {alumno2}");
            }
            else
            {
                Console.WriteLine("Los legajos son distintos");

            }

        Console.ReadKey();

        }

    }
}
