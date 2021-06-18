using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"UBICACION ESTANTE: {estante.ubicacionEstante}");
            sb.AppendLine("PRODUCTOS DEL ESTANTE:");
            foreach (Producto p in estante.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }
            return sb.ToString();
        }


        public static bool operator -(Estante estante, Producto producto)
        {
            bool retorno = false;
            if (!(estante is null) && !(producto is null))
            {
                Producto[] productosAux = estante.GetProductos();
                for (int i = 0; i < estante.GetProductos().Length; i++)
                {
                    if (productosAux[i] == producto)
                    {
                        productosAux[i] = null;
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        //productosAux.Count();
        public static bool operator +(Estante estante, Producto producto)
        {

            if (estante != producto) //si no se existe ese producto en mi estante
            {
                Producto[] productosAux = estante.GetProductos();
                for (int i = 0; i < estante.GetProductos().Length; i++)
                {
                    if (productosAux[i] is null) //si hay espacio
                    {
                       productosAux[i] = producto;
                       return true;
                    }
                }
            }
            return false;
        }

        public static bool operator ==(Estante estante, Producto producto)
        {
            //for (int i = 0; i < estante.productos.Length; i++)
            //{
            //    if(estante.productos[i] == producto)
            //    {
            //        return true;
            //    }
            //}
            //return false;

            bool retorno = false;

            if (!(estante is null))
            {
                foreach (Producto prod in estante.productos)
                {
                    if (prod == producto)
                    {
                        return true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }
    }
}
