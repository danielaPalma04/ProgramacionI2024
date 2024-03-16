
using System;
using System.Collections.Generic;

namespace desafiosSemana6_2
{

    class Program
    {
       
        static void Main(string[] args)
        {
            List<Caja> cajas = new List<Caja>();


            while (true)
            {
                Console.WriteLine("Ingrese el largo de la caja: ");
                int largo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el ancho de la caja: ");
                int ancho = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el alto de la caja: ");
                int alto = int.Parse(Console.ReadLine());

                Caja caja = new Caja(largo, ancho, alto);
                cajas.Add(caja);

                Console.WriteLine("¿Desea ingresar otra caja? (S/N): ");
                string opcion = Console.ReadLine();

                if (opcion.ToLower() == "n")
                {
                    break;
                }
            }


            double volumenTotal = 0;
            foreach (Caja caja in cajas)
            {
                volumenTotal += caja.CalcularVolumen();
            }
            double volumenPromedio = volumenTotal / cajas.Count;

            Console.WriteLine("Volumen total: {0}", volumenTotal);
            Console.WriteLine("Volumen promedio: {0}", volumenPromedio);
        }
    }
}