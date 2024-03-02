using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafios1
{
    class calculadora
    {
        private int num1;
        private int num2;
        private int resultado;

        public calculadora()
        {

        }
        public int Suma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            resultado = num1 + num2;
            return resultado;
        }
        public int Resta(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            resultado = num1 - num2;
            return resultado;
        }
        public int Multiplicacion(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            resultado = num1 * num2;
            return resultado;
        }
        public int Division(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            resultado = num1 / num2;
            return resultado;
        }
    }
}
