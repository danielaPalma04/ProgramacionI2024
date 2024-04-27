using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{

    class Calculadora
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            return num1 / num2;
        }

        class CalculadoraCientifica : Calculadora
        {
            public double RaizCuadrada(double num)
            {
                if (num < 0)

                    return Math.Sqrt(num);
            }

            public double Potencia(double num, double exponente)
            {
                return Math.Pow(num, exponente);
            }

            public double Seno(double angulo)
            {
                return Math.Sin(angulo);
            }

            public double Coseno(double angulo)
            {
                return Math.Cos(angulo);
            }

            public double Tangente(double angulo)
            {
                if (Math.Cos(angulo) == 0)
                {
                    throw new DivideByZeroException();
                }

                return Math.Tan(angulo);
            }
        }
    }
}