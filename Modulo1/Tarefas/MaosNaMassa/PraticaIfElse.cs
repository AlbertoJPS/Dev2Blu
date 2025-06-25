//dica

//notação ponto
//é a forma de acessar membros de um objeto ou classe em C#
//por exemplo, se você tem uma classe chamada "Pessoa" e um membro chamado "Nome",
//você pode acessar o nome de uma pessoa específica usando a notação ponto: pessoa.Nome


namespace Tarefas.MaosNaMassa
{
    public class PraticaIfElse
    {
        public static void VerificarConvidado(string nomeConvidado)
        {
            if (nomeConvidado == "João" ||
                nomeConvidado == "José" ||
                nomeConvidado == "Carlos")
            {
                Console.Write("\nOlá ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(nomeConvidado);
                Console.ResetColor();
                Console.WriteLine(", seja bem-vindo!");
            }
            else if (nomeConvidado == "Ana" ||
                     nomeConvidado == "Maria")
            {
                Console.Write("\nOlá ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(nomeConvidado);
                Console.ResetColor();
                Console.WriteLine(", seja bem-vinda!");
            }
            else
            {
                Console.Write("\nOlá ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(nomeConvidado);
                Console.ResetColor();
                Console.WriteLine(", você não está na lista de convidados.");
            }
        }
    }
}
