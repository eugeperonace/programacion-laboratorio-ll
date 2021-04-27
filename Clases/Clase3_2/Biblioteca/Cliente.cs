using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private int telefono;
        private Mascota[] mascotas;

        public Cliente(string domicilio, string nombre, string apellido, int telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public void AgregarMascota(Mascota mascota)
        {
            if (this.mascotas is null)
            {
                this.mascotas = new Mascota[1]; //CREO un espacio de memoria para Mascota
            }
            else
            {
                int nuevaCapacidad = this.mascotas.Length + 1; //si ya existía un elemento en mi array CAMBIO el tamaño p q entre unonuevo
                Array.Resize(ref this.mascotas, nuevaCapacidad);
            }

            for (int i = 0; i < this.mascotas.Length; i++) //AGREGO a mi array esa mascota que me pasan por parámentro
            {
                if (this.mascotas[i] is null)
                {
                    this.mascotas[i] = mascota;
                    break;
                }
            }
        }

        //GETTERS
        //public string MostrarDatos()
        //{
        //    string retorno = $"\n-----DATOS DEL CLIENTE-----\nNombre: {this.nombre} - Apellido: {this.apellido} - Domicilio: {this.domicilio} - Telefono: {this.telefono}\n";

        //    if (this.mascotas != null) //Si tengo una mascota entro al if
        //    {
        //        retorno += $"Mascotas de {this.nombre} {this.apellido}: ";
        //        foreach (Mascota mascota in this.mascotas)
        //        {
        //            retorno += mascota.MostrarDatos();
        //        }
        //    }
        //    return retorno;
        //}

        public StringBuilder MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("\n---DATOS DEL CLIENTE---");
            retorno.AppendLine($"Nombre: {this.nombre}");      //Si pongo: retorno.AppendLine = $"Nomb" ERROR: no se puede asignar a
            retorno.AppendLine($"Apellido: {this.apellido}");  //AppendLine porque es un grupo de métodos.
            retorno.AppendLine($"Domicilio: {this.domicilio}");
            retorno.AppendLine($"Telefono: {this.telefono}");

            if (this.mascotas != null)
            {
                retorno.Append($"Mascotas de {this.nombre} {this.apellido}: ");
                foreach (Mascota mascota in this.mascotas)
                {
                    if(mascota != null)
                    {
                        retorno.Append(mascota.MostrarDatos()); //Si pongo: retorno = mascota.MostrarDatos(); ERROR: no se puede                                                           convertir implicitamente el tipo string en StringBuilder
                    }
                }
            }
                return retorno;
        }
        //SETTERS
            public void CambiarApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}

