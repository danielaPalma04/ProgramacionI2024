using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosSemana6_1
{
    public class medidas
    {
        public int Alto { get; set; }
        public int Largo { get; set; }

        public medidas(int alto, int largo)
        {
            Alto = alto;
            Largo = largo;
        }

        public int SuperficieFrontal()
        {
            return Alto * Largo;
        }
    }
}