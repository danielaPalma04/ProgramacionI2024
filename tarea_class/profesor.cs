using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_class
{
    public class profesor
    {
        private string nombre;
        private string apellido;
        private string fechaDeNacimiento;
        private int telefono;
        private string facultadAsignada;
        private string cicloAEjercer;
        private string cursoAEnseñar;


        public profesor(string nombre, string apellido, string fechaDeNaciemiento, int telefono, string facultadAsignada, string cicloAEjercer, string cursoAEnseñar)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNaciemiento;
            this.telefono = telefono;
            this.facultadAsignada = facultadAsignada;
            this.cicloAEjercer = cicloAEjercer;
            this.cursoAEnseñar = cursoAEnseñar;

            Console.WriteLine($"Los datos del Profesor son:\nNombre: {nombre} {apellido}\nFecha de Nacimiento: {fechaDeNaciemiento}\nTelefono: {telefono}\n Facultad: {facultadAsignada}\nCiclo: {cicloAEjercer}\nCurso: {cursoAEnseñar}");
        }
    }
}
