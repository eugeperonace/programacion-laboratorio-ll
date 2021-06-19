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

        /// <summary>
        /// Constructor de objeto Vendedor. Inicializa la lista de publicaciones del vendedor.
        /// </summary>
        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        /// <summary>
        /// Constructor de objeto Vendedor, inicializa el estado de su atributo nombre.
        /// </summary>
        /// <param name="nombre"></param>
        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Informa el nombre, ventas y ganancia del vendedor pasado por parámetro.
        /// </summary>
        /// <param name="v">Vendedor de quien queremos saber la información.</param>
        /// <returns>string con dicha información.</returns>
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

        /// <summary>
        /// Agrega una publicación a la lista de ventas del vendedor.
        /// </summary>
        /// <param name="v">Vendedor</param>
        /// <param name="p">Publicacion a agregar</param>
        /// <returns>true si pudo agregarla y false si no pudo.</returns>
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
