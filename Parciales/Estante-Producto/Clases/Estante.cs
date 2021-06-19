using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            if (!(e is null))
            {
                sb.AppendLine($"Ubicacion del Estante: {e.ubicacionEstante}");
                sb.AppendLine($"Productos del Estante: ");
                foreach (Producto producto in e.productos)
                {
                    sb.AppendLine(Producto.MostrarProducto(producto));
                }
            }
            return sb.ToString();
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);        
        }

        public static bool operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                Producto[] productosAux = e.GetProductos();
                for (int i = 0; i < productosAux.Length; i++)
                {
                    if (productosAux[i] == p)
                    {
                        productosAux[i] = null;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                Producto[] productosAux = e.GetProductos();
                for (int i = 0; i < productosAux.Length; i++)
                {
                    if ((productosAux[i] is null))
                    {
                        productosAux[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            if (!(e is null))
            {
                foreach (Producto producto in e.productos)
                {
                    if (producto == p)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
