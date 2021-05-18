using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        #region Constructores

        /// <summary>
        /// Constructor de objeto Biografía, inicializa el estado de su atributo nombre.
        /// </summary>
        /// <param name="nombre"></param>
        public Biografia(string nombre) : base(nombre)
        {
        }

        /// <summary>
        /// Constructor de objeto Biografía, inicializa el estado de su atributo nombre y stock.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        public Biografia(string nombre, int stock) : base(nombre,stock)
        {
        }

        /// <summary>
        /// Constructor de objeto Biografía, inicializa el estado de su atributo nombre, stock y valor.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="stock"></param>
        /// <param name="valor"></param>
        public Biografia(string nombre, int stock, float valor) : base(nombre, stock, valor)
        { 
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Si es de color retorna true si no, false.
        /// </summary>
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Si tiene stock retorna true sin importar el valor de la venta, si no hay stock retorna false.
        /// </summary>
        public override bool HayStock
        {
            get
            {
                bool retorno = false;
                if(this.stock > 0)
                {
                    retorno = true;
                }
                return retorno;
            }
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Conversión explícita que genera un objeto Biografía.
        /// </summary>
        /// <param name="nombre"></param>
        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }

        #endregion

    }
}
