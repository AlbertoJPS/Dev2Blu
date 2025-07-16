
namespace Sistema_Central.Utilitários
{
    public static class Seletores
    {
        public static TipoEnum SelecionarOpcaoEnum<TipoEnum>() where TipoEnum : Enum
        {
            Array opcoesEnum = Enum.GetValues(typeof(TipoEnum));

            Console.WriteLine($"\nSelecione uma opção para {typeof(TipoEnum).Name}:\n");

            for (int indice = 0; indice < opcoesEnum.Length; indice++)
            {
                Console.WriteLine($"[{indice}] {opcoesEnum.GetValue(indice)}");
            }

            Console.Write("\nDigite o número correspondente à opção desejada: ");

            int escolha;
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 0 || escolha >= opcoesEnum.Length)
            {
                Console.Write("Opção inválida. Tente novamente: ");
            }

            return (TipoEnum)opcoesEnum.GetValue(escolha);
        }
    }
}
