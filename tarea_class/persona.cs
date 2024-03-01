using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_class
{
    public class persona
    {
        //atributos
        private string nombre;
        private string apellido;
        private string fechaNacimiento;
        private int telefono;
        private string direccion;

        public persona(string nombre, string apellido, string fechaNacimiento, int telefono, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.direccion = direccion;

            Console.WriteLine($"Nombre: {nombre}{apellido}\nFecha de nacimiento: {fechaNacimiento}\nTelefono{telefono}\nDirección: {direccion}\n");
        }
    }
}
