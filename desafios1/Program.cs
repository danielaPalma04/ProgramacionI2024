using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafios1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Desafío suma y promedio de salarios\n");
                sumaYPromedio salario = new sumaYPromedio("Lisbeth", 1000, 1000, 1000);

                      
                Console.WriteLine("Metodos de suma, resta, multiplicacion y division llamados desde otra clase y con dos parametros de tipo int.\n");
                calculadora operaciones = new calculadora();
                //suma
                Console.WriteLine($"El resultado de la suma es: {operaciones.Suma(8, 5)}\n");
                //resta
                Console.WriteLine($"El resultado de la resta es: {operaciones.Resta(20, 15)}\n");
                //multiplicacion
                Console.WriteLine($"El resultado de la multiplicacion es: {operaciones.Multiplicacion(4, 4)}\n");
                //division
                Console.WriteLine($"El resultado de la division es: {operaciones.Division(10, 2)}\n");

            }
        }
    }
}
