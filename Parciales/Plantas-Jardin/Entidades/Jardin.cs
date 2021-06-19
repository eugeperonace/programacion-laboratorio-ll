using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        public enum Tipo
        {
            Terrozo,
            Arenoso
        }

        public Tipo TipoSuelo
        {
            set
            {
                suelo = value;
            }
        }

        public int EspacioOcupado()
        {
            int ocupado = 0;

            foreach (Planta plant in this.plantas)
            {
                ocupado += plant.Tamanio;
            }

            return ocupado;

        }

        public int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio; 
        }

        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            bool retorno = false;
            if (!(jardin is null) && !(planta is null))
            {

                if (jardin.EspacioOcupado(planta) <= jardin.espacioTotal)
                {
                    jardin.plantas.Add(planta);
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Composición del jardín: {0}", Jardin.suelo));
            sb.AppendLine(String.Format("Espacio ocupado {0} de {1}", this.EspacioOcupado(), this.espacioTotal));
            sb.AppendLine("\nLISTA DE PLANTAS");
            
            foreach (Planta plant in this.plantas)
            {
                sb.AppendLine(plant.ResumenDeDatos());
            }

            return sb.ToString();
        }


    }
}
