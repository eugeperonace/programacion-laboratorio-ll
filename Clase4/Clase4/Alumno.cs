using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private long dni;
        private DateTime fechaNacimiento;

        //SOBRECARGA DE MÉTODOS
        public Alumno(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public Alumno(string nombre, string apellido, string legajo)
            : this(new DateTime(1996, 08, 05))                          //construyo la fecha acá y se la paso al constructor de arriba
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.SetLegajo(legajo);
        }

        public Alumno(string nombre, string apellido, string legajo, long dni)
            : this(nombre, apellido, legajo)                           //invoco al otro constructor acá para reutilizar código
        {
            this.dni = dni;
        }

        public void SetLegajo(string x)          //si toda la validacion da bien, asigno el legajo, quiero que los legajos se validen
        {
            string aux = x;
            //VALIDAR
            this.legajo = aux;

        }

        //SOBRECARGA DE OPERADORES
        public static Alumno operator + (Alumno a, int x)  //ej. si sumo un Alumno con un entero incremento el dni 
        {
            a.dni += x;
            return a;
        }

        //CONVERSIÓN IMPLÍCITA
        public static implicit operator Alumno (DateTime dt) //no hay pérdida de info.
        {
            return new Alumno(dt);
        }

        //COMO LO USARÍA EN EL MAIN
        /*Alumno a2 = new DateTime();
         a2  = a2 + 10;
        */
    }
}