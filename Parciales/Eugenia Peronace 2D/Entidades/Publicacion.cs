using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Publicacion
    {
        #region Atributos

        protected float importe;
        protected string nombre;
        protected int stock;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de objeto Publicación, inicializa el estado de su atributo nombre.
        /// </summary>
        /// <param name="nombre"></param>
        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor de objeto Publicación, inicializa el estado de su atributo nombre y stock.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }

        /// <summary>
        /// Constructor de objeto Publicación, inicializa el estado de su atributo nombre, stock e importe.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        /// <param name="importe"></param>
        public Publicacion(string nombre, int stock, float importe) : this(nombre,stock)
        {
            this.importe = importe;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Si la publicación es de color retorna true si no, false.
        /// </summary>
        protected abstract bool EsColor 
        {
            get;
        }

        /// <summary>
        /// Si la publicación tiene stock retorna true, si no false.
        /// </summary>
        public virtual bool HayStock
        {
            get
            {
                bool retorno = false;
                if (this.stock > 0 && this.importe > 0)
                {
                    retorno = true;
                }
                return retorno;
            }
        }

        /// <summary>
        /// Retorna el importe del objeto.
        /// </summary>
        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        /// <summary>
        /// Retorna el stock y permite setear dicho stock si ese valor es mayor a 0.
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }

            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Muestra la información de la Publicación.
        /// </summary>
        /// <returns>un string con dicha información.</returns>
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.nombre}\n");
            sb.AppendFormat("Stock: {0}\n", this.stock);
            if(this.EsColor)
            {
                sb.AppendLine("Color: SI");
            }
            else
            {
                sb.AppendLine("Color: NO");
            }
            sb.AppendLine($"Valor: ${this.importe}");

            return sb.ToString();
        }

        /// <summary>
        /// Retorna el nombre.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre;
        }

        #endregion

    }
}
