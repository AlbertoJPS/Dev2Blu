namespace TarefasAula.MaosNaMassa
{
    public class PraticaIfElse
    {
        static void Main(string[] args)
        {
        }
        public static void VerificarConvidado()
        {
            string nomeConvidado;
           
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
