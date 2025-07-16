using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14.ClassOO
{
    internal class Sistema
    {
        public static DateTime DataInicializaçâo { get; set; }

        public static int LerInteiro( string mensagem)
        {
            Console.Write(mensagem);
            var entrada = Console.ReadLine();
            int.TryParse(entrada, out int resultado);

            return resultado;
        }
        public static char LerChar(string mensagem)
        {
            Console.Write(mensagem);
            var entrada = Console.ReadLine();

            return entrada == null ? ' ' : entrada[0];

        }
    }

}
