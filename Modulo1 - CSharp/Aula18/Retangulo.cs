
namespace Aula18
{
    internal class Retangulo : FormaGeometrica
    {
        private const int LADOS_DUPLICADOS = 2;

        public override string Nome => "retângulo";
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return LADOS_DUPLICADOS * (Largura + Altura);
        }

        public static void OpcaoRetangulo()
        {
            FormaGeometrica formaEscolhida = null;

            Console.Write("\nDigite a largura do retângulo: ");
            if (double.TryParse(Console.ReadLine(), out double largura))
            {
                Console.Write("Digite a altura do retângulo: ");
                if (double.TryParse(Console.ReadLine(), out double altura))
                {
                    formaEscolhida = new Retangulo(largura, altura);
                    Console.WriteLine(formaEscolhida.ToString());
                }
                else
                {
                    Console.WriteLine("\nValor inválido para a altura.");
                }
            }
            else
            {
                Console.WriteLine("\nValor inválido para a largura.");
            }
        }
    }
}
