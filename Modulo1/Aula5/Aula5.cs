
// Codicionais if, else if, else

//Console.WriteLine("Me informe sua idade.\n");
//var idade = int.Parse(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine("Você é maior de idade");
//}
//else if (idade == 0)
//{
//    Console.WriteLine("Você ainda é recem nascido");
//}
//else
//{
//    Console.WriteLine("Você é menor de idade");
//}

using Tarefas.MaosNaMassa;

namespace Aula5
{
    class Aula5
    {
        static void Main(string[] args)
        {
            string nomeConvidado;
            Console.WriteLine("\n\nDigite o nome do convidado:\n");
            nomeConvidado = Console.ReadLine();

            // Uso da classe PraticaIfElse para verificar o convidado
            PraticaIfElse.VerificarConvidado(nomeConvidado);
        }
    }
}


