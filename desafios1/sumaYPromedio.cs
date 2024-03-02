using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafios1
{
    class sumaYPromedio
    {
        private int salario1;
        private int salario2;
        private int salario3;
        private string usuario;
        private int suma;
        private int promedio;

        public void SumaYPromedio(string usuario, int salario1, int salario2, int salario3)
        {
            this.salario1 = salario1;
            this.salario2 = salario2;
            this.salario3 = salario3;
            this.usuario = usuario;
            this.suma = suma;
            this.promedio = promedio;

            suma = salario1 + salario2 + salario3;
            promedio = suma / 3;

            Console.WriteLine($"Hola {usuario}, el total de tu salario es: ${suma}\nY promediaste un total de: ${promedio}");
        }
    }

}
    
}
