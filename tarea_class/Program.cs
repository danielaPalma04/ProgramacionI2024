using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos una nueva persona
            persona persona = new persona("Maria", "Rodriguez", "03/07/2001", 12345678, "Jalapa");

            // creamos un nuevo alumno
            alumno alumno = new alumno("Daniela", "Palma", "26/10/2004", 41831714, "Jalapa", "0907-23-15075", "Ingeniería en sistemas", "Tercero" );

            // creamos un nuevo profesor
            profesor profesor = new profesor("Marco", "Valdez", "04/06/1981", 87654321, "Ingeniería en Sistemas", "Tercero", "Programacion 1");

            // creamos un nuevo coordinador
            coordinador coordinador = new coordinador("Ricardo", "Hernandez", 42560144, "Universidad Mariano Galvez de Guatemala", "Jalapa", "INgeniería en sistemas");

            Console.ReadKey();

        }
    }
   
}
