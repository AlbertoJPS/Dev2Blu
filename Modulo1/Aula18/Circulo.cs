
namespace Aula18
{
    internal class Circulo : FormaGeometrica
    {
        private const int POTENCIA_QUADRADO = 2;
        public override string Nome => "círculo";
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, POTENCIA_QUADRADO);
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
        public static void OpcaoCirculo()
        {
            FormaGeometrica formaEscolhida = null;

            Console.Write("\nDigite o raio do círculo: ");
            if (double.TryParse(Console.ReadLine(), out double raio))
            {
                formaEscolhida = new Circulo(raio);
                Console.WriteLine(formaEscolhida.ToString());
            }
            else
            {
                Console.WriteLine("\nValor inválido para o raio.");
            }
        }
    }
}
