using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido; // private: solo son accesibles desde la misma clase

        public Cliente(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        //SETTERS
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void CambiarApellido(string apellido)
        {
            this.apellido = apellido;
        }

        //GETTER
        public string ObtenerNombreCompleto()
        {
            //return nombre + " " + apellido;
            return $"{this.nombre} {this.apellido}"; //hace referencia a algo que es un objeto de esta clase // TEMPLATE STRING

        }
    }
}