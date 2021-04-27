using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private Vacuna[] vacunas; //no es un dato obligatocio o requerido para que funcionen mis objetos Mascota

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void AgregarVacuna(Vacuna vacuna) //CREO espacio de memoria para Vacuna
        {
            if (this.vacunas is null)
            {
                this.vacunas = new Vacuna[1];
            }
            else
            {
                int nuevaCapacidad = this.vacunas.Length + 1; //si ya existe un elemento, CREO uno más
                Array.Resize(ref this.vacunas, nuevaCapacidad);
            }

            for (int i = 0; i < this.vacunas.Length; i++) //AGREGO al array la vacuna que me pasan por parámetros 
            {
                if (this.vacunas[i] is null)
                {
                    this.vacunas[i] = vacuna;
                    break;
                }
            }
        }


        //GETTERS
        public string MostrarDatos()
        {
            string retorno = $"\nNombre: {this.nombre} - Especie: {this.especie} - Fecha de nacimiento: {this.fechaNacimiento.ToShortDateString()} - ";

            if (this.vacunas != null) //Si tengo una vacuna cargada entro al if 
            {
                retorno += "Vacuna/s: ";
                foreach (Vacuna vacuna in this.vacunas)
                {
                    if (vacuna != null)
                    {
                        retorno += vacuna.ObtenerNombre();
                    }
                }
            }
            return retorno;
        }
    }
}