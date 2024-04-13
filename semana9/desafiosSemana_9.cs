using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace desafiosSemana_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Hola, este es mi Correo Electrónico: Lpalmac2@miumg.edu.gt. /nPor favor, envíeme un correo con sus documentos faltantes.";

            string patronCorreo = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";

            // con el objeto Regex busca el patrón.
            Regex busqueda = new Regex(patronCorreo);

            MatchCollection coincidencias = busqueda.Matches(texto);

            foreach (Match match in coincidencias)
            {
                Console.WriteLine(match.Value);

            }
        }
    }
}
