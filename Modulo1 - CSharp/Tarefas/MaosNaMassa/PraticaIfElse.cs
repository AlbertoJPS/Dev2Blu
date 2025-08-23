namespace Tarefas.MaosNaMassa
{
    public class PraticaIfElse
    {
        public static void VerificarConvidado()
        {
            string nomeConvidado;
            Console.WriteLine("\n\nDigite o nome do convidado:\n");
            nomeConvidado = Console.ReadLine();

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
