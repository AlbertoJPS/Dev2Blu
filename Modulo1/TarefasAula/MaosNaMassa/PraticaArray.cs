
namespace TarefasAula.MaosNaMassa
{
    public class PraticaArray
    {
        public static void ExecutarArray()
        {
            string[] nomes = new string[5];
            double[] notas = new double[5];

            Console.WriteLine("\nDigite o nome e a nota dos alunos. \n(dica: use vírgula para notas com números depois da virgula)");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"\nDigite o nome do aluno {i + 1}: ");
                nomes[i] = Console.ReadLine();
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("\n\nNotas de Alunos");

            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"{nomes[i]}: {notas[i].ToString("F2")}\n");
            }

            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }

    }
}
