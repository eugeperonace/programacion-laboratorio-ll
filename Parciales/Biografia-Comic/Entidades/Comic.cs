using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Publicacion
    {
        #region Atributos

        private bool esColor;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de objeto Comic, inicializa el estado de sus atributos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="esColor"></param>
        /// <param name="stock"></param>
        /// <param name="valor"></param>
        public Comic(string nombre, bool esColor, int stock, float valor) : base(nombre, stock, valor)
        {
            this.esColor = esColor;
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
                return this.esColor;
            }
        }

        #endregion
    }
}
