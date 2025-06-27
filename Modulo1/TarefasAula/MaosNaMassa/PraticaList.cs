

namespace TarefasAula.MaosNaMassa
{
    public class PraticaList
    {
        public static void CriarLista()
        {

            List<string> nomes = new List<string>();
            List<double> notas = new List<double>();

            Console.WriteLine("\n\nDigite o número de alunos na classe:");
            int numeroAlunos = int.Parse(Console.ReadLine());
                  
            Console.WriteLine("\nDigite o nome e a nota dos alunos. \n(dica: use vírgula para notas com números depois da virgula)");

            for (int i = 0; i < numeroAlunos; i++)
            {
                Console.Write($"\nDigite o nome do aluno {i + 1}: ");
                nomes.Add(Console.ReadLine());
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                notas.Add(double.Parse(Console.ReadLine()));
            }

            Console.Clear();

            Console.WriteLine("\n\nNotas de Alunos");

            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

            int contador = 0;
            foreach (string aluno in nomes)
            {
                Console.WriteLine($"{nomes[contador]}: {notas[contador].ToString("F2")}\n");
                contador++;
            }

            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        }
    }
}
