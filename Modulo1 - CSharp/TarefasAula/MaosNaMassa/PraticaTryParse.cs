using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasAula.MaosNaMassa
{
    public class PraticaTryParse
    {
        public static void ExecutaTryParse()
        {
            Console.WriteLine("Digite um número:");
            var entrada = Console.ReadLine();

            var converteu = double.TryParse(entrada, out double resultado);
            //converteu = double.TryParse(entrada, out resultado); // Outra forma de escrever a mesma coisa (antigo)

            Console.WriteLine($"Converteu: {converteu}");
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
