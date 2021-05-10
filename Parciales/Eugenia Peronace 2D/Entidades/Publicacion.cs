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

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe) : this(nombre,stock)
        {
            this.importe = importe;
        }

        #endregion

        #region Propiedades

        protected abstract bool EsColor 
        {
            get;
        }

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


        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

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

        public override string ToString()
        {
            return this.nombre;
        }

        #endregion

    }
}
