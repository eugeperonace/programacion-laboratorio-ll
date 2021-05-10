using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        #region Atributos

        private string nombre;
        private List<Publicacion> ventas;

        #endregion

        #region Constructores

        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #endregion

        #region Métodos

        public static string InformeDeVentas(Vendedor v)
        {
            double ganancia = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {v.nombre}");
            sb.AppendLine("------------------");

            sb.Append("PUBLICACION: ");

            foreach (Publicacion publication in v.ventas)
            {
                sb.AppendLine(publication.Informacion());
                ganancia += publication.Importe;
                sb.AppendLine("------------------");
            }

            sb.AppendFormat("Ganancia Total: ${0}", ganancia);

            return sb.ToString();
        }

        #endregion

        #region Operadores

        public static bool operator +(Vendedor v, Publicacion p)
        {
            bool retorno = false;

            if (!(v is null) && !(p is null))
            {
                if (p.HayStock)
                {
                    v.ventas.Add(p);
                    p.Stock--;
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion
    }
}
