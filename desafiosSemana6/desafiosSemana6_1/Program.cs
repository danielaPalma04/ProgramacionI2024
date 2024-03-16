
using System;

namespace desafiosSemana6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el largo: ");
            string var = Console.ReadLine();
            int largo = int.Parse(var);
            Console.WriteLine("Ingrese el alto: ");
            int alto = int.Parse(Console.ReadLine());

            medidas dates = new medidas(alto, largo);
            dates.SuperficieFrontal();


        }
    }
}