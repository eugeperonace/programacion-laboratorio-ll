using System;
using System.Text;

namespace Clases
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
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
            sb.AppendFormat("MARCA: {0}\n",p.marca);
            sb.Append($"PRECIO: {p.precio}\n");
            sb.AppendLine($"CODIGO DE BARRA: {p.codigoDeBarra}");
            return sb.ToString();
        }

        public static explicit operator string(Producto p) 
        {
            return p.codigoDeBarra;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (!(p is null) && !(marca is null) && (p.marca == marca))
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null) && !(p2 is null) && (p1.marca == p2.marca) && (p1.codigoDeBarra == p2.codigoDeBarra))
            {
                return true;
            }
            return false;
        }
    }
}
