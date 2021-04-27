using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Auto
    {
        private static int cantidadRuedas;      //Si instancio Auto 50 veces, en memoria voy a tener a CantidadRuedas una sola vez.
        private string marca;                   //encambio marca va a esta 50 veces,
        private string modelo;                                        //porque CantidadRuedas: ES DE LA CLASE y marca: ES DEL OBJETO.

        public Auto(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        static Auto() //Los constructores estáticos no deben tener parámentros, xq hace referencia a la Clase no al objeto.
        {
            Auto.cantidadRuedas = 4;
        }

        //GETTERS
        public string GetAuto() //Ponemos this. porque marca no es estático, es público, accede al objeto, a la instancia.
        {
            return $"La marca del auto es: {this.marca} y el modelo es: {this.modelo}";
        }

        public static int GetCantidadRuedas() //Ponemos Auto. porque es estático, accede a lo de la Clase, a lo estático.
        {
            return Auto.cantidadRuedas;
        }

        //SETTERS 
        public static void SetCantidadRuedas(int cantidad)
        {
            Auto.cantidadRuedas = cantidad;
        }
    }
}