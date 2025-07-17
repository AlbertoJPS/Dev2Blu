using Sistema_Central.Entities;
using Sistema_Central.Utilitários;


namespace Sistema_Central
{
    public static class Cadastros
    {
        public static void CadastrarAstronauta(List<Astronauta> astronautas)
        {
            string nome = Service.LerTextoObrigatorio("Nome do astronauta: ");
            var pais = Service.SelecionarOpcaoEnum<PaisAstronauta>();

            DateTime nascimento;
            Console.Write("Data de nascimento (dd/mm/aaaa): ");
            while (!DateTime.TryParse(Console.ReadLine(), out nascimento))
            {
                Console.Write("Data inválida. Tente novamente (dd/mm/aaaa): ");
            }

            var novoAstronauta = new Astronauta(nome, pais, nascimento);
            astronautas.Add(novoAstronauta);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAstronauta cadastrado com sucesso!");
            Console.ResetColor();
        }


        public static void CadastrarNave(List<Nave> naves)
        {
            string nome = Service.LerTextoObrigatorio("Nome da nave: ");
            string modelo = Service.LerTextoObrigatorio("Modelo da nave: ");
            var porte = Service.SelecionarOpcaoEnum<PorteNave>();
            var fabricante = Service.SelecionarOpcaoEnum<PaisFabricante>();
            var objetivos = Service.SelecionarMultiplasOpcoesEnum<ObjetivoMissao>();

            if (objetivos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhum objetivo selecionado. Cadastro cancelado.");
                Console.ResetColor();
                return;
            }

            var novaNave = new Nave(nome, modelo, porte, fabricante, objetivos);
            naves.Add(novaNave);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNave cadastrada com sucesso!");
            Console.ResetColor();
        }

        public static void CadastrarPlaneta(List<Planeta> planetas)
        {
            string nome = Service.LerTextoObrigatorio("Nome do planeta: ");
            string descricao = Service.LerTextoObrigatorio("Descrição: ");

            double distancia;
            Console.Write("Distância em UA (ex: 4.2): ");
            while (!double.TryParse(Console.ReadLine(), out distancia) || distancia < 0)
            {
                Console.Write("Valor inválido. Digite novamente a distância em UA: ");
            }

            var situacao = Service.SelecionarOpcaoEnum<SituacaoPlaneta>();
            var novoPlaneta = new Planeta(nome, descricao, distancia, situacao);
            planetas.Add(novoPlaneta);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlaneta cadastrado com sucesso!");
            Console.ResetColor();
        }
    }
}
