using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_class
{
    class coordinador
    {
        private string nombre;
        private string apellido;
        private int telefono;
        private string institucion;
        private string sede;
        private string facultadCoordinador;

        public coordinador(string nombre, string apellido, int telefono, string institucion, string sede, string facultadCoordinador)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.institucion = institucion;
            this.sede = sede;
            this.facultadCoordinador = facultadCoordinador;
            Console.WriteLine($"Los datos del Coordinador son:\nNombre: {nombre} {apellido}\nTelefono: {telefono}\nInstitucion: {institucion}\nSede: {sede}\nFacultad que coordina: {facultadCoordinador}\n");
        }
    }
}
