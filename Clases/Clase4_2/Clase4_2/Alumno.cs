using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_2
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private long dni;

        public Alumno(string nombre, string apellido, long dni, int legajo) //Tenemos 2 constructores, uno en el que se inicializan los valores de
            : this(nombre, apellido, dni)                                  //nombre, apellido y dni y otro en el que reutilizo el código del otro 
        {                                                                 //constructor usando el this y ahí cargo el legajo con un valor q yo le pase
            this.legajo = legajo;                                        //cuando instancie mi objeto.
        }

        public Alumno(string nombre, string apellido, long dni) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.legajo = 0;
        }

        public void SetLegajo(Alumno alumno, int legajo)                //hago una propiedad para setear el legajo, así no hago visible el atributo
        {
            alumno.legajo = legajo;
        }

        public int GetLegajo()
        {
            return this.legajo;
        }

        //CONVERSIÓN EXPLÍCITA
        public static explicit operator long (Alumno alumno)
        {
            return alumno.dni;
        }

        //CONVERSIÓN IMPLICITA
        public static implicit operator int (Alumno alumno)
        {
            return alumno.legajo;
        }
        
        //SOBRECARGA DEL OPERADOR +
        /// <summary>
        /// Agrega el legajo al alumno y si pudo agregarlo retorna true
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="legajo"></param>
        /// <returns> retorna true si el legajo pudo ser cargado y false si no pudo.
        public static bool operator +(Alumno alumno, int legajo)
        {
            bool retorno = false;
            alumno.SetLegajo(alumno, legajo); //alumno.legajo = legajo;

            if (alumno.legajo != 0)
            {
                retorno = true;
            }

            return retorno;
        }

        //public static Alumno operator +(Alumno alumno, int legajo)
        //{
        //    alumno.SetLegajo(alumno, legajo);
        //    return alumno;
        //}

        //SOBRECARGA DE OPERADOR ==
        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            bool retorno = false;

            if (alumno1.legajo == alumno2.legajo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1 == alumno2);
        }

    }
}
