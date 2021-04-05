/*Un cliente nos contrató para que desarrollemos una aplicación donde pueda consultar su lista de clientes y sus mascotas. 
De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas. 
De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación.  Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último arrancará vacío y se podrá ir agregando vacunas. De las vacunas sólo interesa conocer el nombre. 

1. Crear una aplicación de consola.
2. Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
3. Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
4. Instanciar los siguientes objetos (hardcodeado, no pedir datos por consola):
- Un cliente con un perro sin vacunar.
- Un cliente con un gato con la vacuna "Triple Felina".
- Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
5. Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Fragata Sarmiento 1633", "Eugenia", "Peronace", 1537855224);
            Mascota mascota = new Mascota("Gato", "Benji", new DateTime(2020, 07, 11));
            Mascota mascota4 = new Mascota("Gato", "Cati", new DateTime(2002, 06, 05));
            Vacuna vacunaRabia = new Vacuna("Rabia");
            Vacuna vacunaHepatitis = new Vacuna("Hepatitis");

            Cliente cliente2 = new Cliente("Gallardo 602", "Tobias", "Simicek", 1538382727);
            Mascota mascota2 = new Mascota("Perro", "Teo", new DateTime(2018, 08, 05));
            Mascota mascota3 = new Mascota("Pájaro", "Kyara", new DateTime(2015, 07, 07));
            Vacuna vacunaMoquillo = new Vacuna("Moquillo");
            Vacuna vacunaLeucemia = new Vacuna("Leucemia");

            mascota.AgregarVacuna(vacunaRabia);
            mascota.AgregarVacuna(vacunaHepatitis);
            mascota4.AgregarVacuna(vacunaHepatitis);
            cliente.AgregarMascota(mascota);
            cliente.AgregarMascota(mascota4);

            Console.WriteLine(cliente.MostrarDatos());

            mascota2.AgregarVacuna(vacunaMoquillo);
            cliente2.AgregarMascota(mascota2);
            cliente2.AgregarMascota(mascota3);

            Console.WriteLine(cliente2.MostrarDatos());

            Console.ReadKey();
        }
    }
}