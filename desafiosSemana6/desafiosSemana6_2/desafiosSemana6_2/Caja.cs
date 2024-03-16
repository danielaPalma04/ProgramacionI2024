using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosSemana6_2
{

    public class Caja
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }

        // Constructor
        public Caja(int alto, int ancho, int largo)
        {
            Alto = alto;
            Ancho = ancho;
            Largo = largo;
        }


        public double CalcularVolumen()
        {
            return Alto * Ancho * Largo;
        }
    }

}