namespace TarefasAula.MaosNaMassa
{
    public class PraticaWhile
    {
        public static void ExecutarWhile()
        {

            double maior = double.MinValue; // Inicializa com o menor valor possível
            double menor = double.MaxValue; // Inicializa com o maior valor possível

            Console.WriteLine("Me informe um número, ou OK para sair:");
            string entrada = Console.ReadLine();

            //while (entrada.ToUpper() != "OK" && double.TryParse(entrada, out double valor) != false)
            while (entrada.ToUpper() != "OK")
            {
                if (double.TryParse(entrada, out double valor))
                {
                    maior = valor > maior ? valor : maior; 
                    menor = valor < menor ? valor : menor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                    entrada = Console.ReadLine();
                }
            }

            Console.WriteLine("Terminamos aqui:");
            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
        }
    }
}
