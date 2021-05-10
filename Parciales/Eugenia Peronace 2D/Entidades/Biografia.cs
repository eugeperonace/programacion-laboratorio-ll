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

        public Biografia(string nombre) : base(nombre)
        {
        }

        public Biografia(string nombre, int stock) : base(nombre,stock)
        {
        }

        public Biografia(string nombre, int stock, float valor) : base(nombre, stock, valor)
        { 
        }

        #endregion

        #region Propiedades

        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

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

        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }

        #endregion

    }
}
