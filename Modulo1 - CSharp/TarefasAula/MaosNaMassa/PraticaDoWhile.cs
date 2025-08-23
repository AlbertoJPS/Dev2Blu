namespace TarefasAula.MaosNaMassa
{
    public class PraticaDoWhile
    {
        const string SENHA_CORRETA = "@bacateO8";
        public static void ExecutarDoWhile()
        {
            Console.WriteLine("\n\nBem Vindo Usuário, digite sua senha para entrar\n");

            string senhaEntrada;
            bool continua = false;

            do
            {
                Console.Write("\nDigite sua Senha: ");

                if ((senhaEntrada = LerSenha()) == SENHA_CORRETA)
                {
                    Console.WriteLine("\nSenha Correta! Acesso Permitido.");
                    continua = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSenha Incorreta! Tente novamente.\n");
                    Console.ResetColor();
                    continua = true;
                }
            }
            while (continua);

            Console.Clear();
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nVocê está logado!");
            Console.ResetColor();
            Console.WriteLine("\n\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }

        static string LerSenha()
        {
            string senha = "";
            ConsoleKeyInfo digito;

            while ((digito = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (digito.Key == ConsoleKey.Backspace && senha.Length > 0)
                {
                    senha = senha[0..^1];
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(digito.KeyChar))
                {
                    senha += digito.KeyChar;
                    Console.Write("*");
                }
            }
            return senha;
        }
    }
}
