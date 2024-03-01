using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_class
{
    public class alumno : persona
    {
        private string carnet;
        private string carrera;
        private string semestre;

        public alumno(string nombre, string apellido, string fechaNacimiento, int telefono, string direccion, string carnet, string carrera, string semestre) : base(nombre, apellido, fechaNacimiento, telefono, direccion)
        {
            if (string.IsNullOrEmpty(carnet))
            {
                throw new ArgumentException("El carnet no puede estar vacío.");
            }

            this.carnet = carnet;
            this.carrera = carrera;
            this.semestre = semestre;

            Console.WriteLine("Datos del alumno: \n Nombre: {nombre}{apellido}\nFecha de nacimiento; {fechaNacimiento}\n Telefono: {telefono}\nDirección: {dirección}\ncarnet: {carnet}\ncarrera: {carrera}\nsemestre: {semestre}\n");
           
        }

    }
}
