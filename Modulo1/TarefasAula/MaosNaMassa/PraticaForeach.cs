
namespace TarefasAula.MaosNaMassa
{
    public class PraticaForeach
    {
        public static void ExecutarForeach()
        {
            List<string> turma = new List<string>();

            int count = 1;
            bool continua = true;

            Console.WriteLine("\nCadastro de turma");

            do
            {
               Console.WriteLine($"\nDigite o nome do aluno {count} (ou digite 'ok' para encerrar): ");
                string aluno = Console.ReadLine();

                if (aluno.ToLower() != "ok")
                {
                    turma.Add(aluno);
                    continua = true;
                    count++;
                }
                else
                {
                    continua = false;
                }
            } while (continua);

            Console.Clear();

            Console.WriteLine("\nCadastrada turma");
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            count = 0;

            foreach (string alunos in turma)
            {
                count++;
                Console.WriteLine($"\n#{count}  {alunos}");
            }

            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
