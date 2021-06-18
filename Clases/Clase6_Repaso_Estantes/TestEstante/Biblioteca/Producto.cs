using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"MARCA: {p.marca}");
            sb.AppendLine($"CÓDIGO: {p.codigoDeBarras}");
            sb.AppendLine($"PRECIO: {p.precio}");

            return sb.ToString();
        }

        //codigoDeBarras es privado y como no le declaramos un getter, si lo queremos usar desde el Main no podemos. La única forma de obtenerlo es a través de una conversión explícita.
        //Convierto un producto a string. convierto un producto a su codigo de barras
      
        public static explicit operator string(Producto producto) 
        {
            return producto.codigoDeBarras;
        }

        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto producto, string marca)
        {
            bool retorno = false;
            
            if (!(producto is null) && !(marca is null))
            {
                if (producto.marca == marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (!(p1 is null) && !(p2 is null))
            {
                if ((p1.marca == p2.marca) && (p1.codigoDeBarras == p2.codigoDeBarras))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        // return (p1 == p2.marca && p1.codigoDeBarras == p2.codigoDeBarras);
    }
}



