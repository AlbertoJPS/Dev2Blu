
namespace Aula18
{
    internal class Triangulo : FormaGeometrica
    {
        private const double EVITA_IGUALDADE = 0.0001;
        private const double DIVISOR_SEMIPERIMETRO = 2.0;

        public override string Nome => "triângulo";
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double a, double b, double c)
        {
            LadoA = a;
            LadoB = b;
            LadoC = c;
        }

        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public override double CalcularArea()
        {
            double semiperimetro = CalcularPerimetro() / DIVISOR_SEMIPERIMETRO;

            //Formula de Heron para calcular a área de um triângulo
            // A = Área    s = semiperímetro   a = LadoA   b = LadoB   c = LadoC

            //A = √s x (s − a) x (s − b) x (s - c) 

            double area = Math.Sqrt(semiperimetro * (semiperimetro - LadoA) * (semiperimetro - LadoB) * (semiperimetro - LadoC));

            return area;
        }
        public static void OpcaoTriangulo()
        {
            FormaGeometrica formaEscolhida = null;

            Console.Write("\nDigite o lado A do triângulo: ");
            if (double.TryParse(Console.ReadLine(), out double ladoA))
            {
                Console.Write("Digite o lado B do triângulo: ");
                if (double.TryParse(Console.ReadLine(), out double ladoB))
                {
                    double minLadoC = Math.Abs(ladoA - ladoB) + EVITA_IGUALDADE;
                    double maxLadoC = ladoA + ladoB - EVITA_IGUALDADE;

                    Console.Write($"Digite o lado C do triângulo (entre {minLadoC:F2} e {maxLadoC:F2}): ");
                    if (double.TryParse(Console.ReadLine(), out double ladoC))
                    {
                        if (ladoC > minLadoC && ladoC < maxLadoC)
                        {
                            formaEscolhida = new Triangulo(ladoA, ladoB, ladoC);
                            Console.WriteLine(formaEscolhida.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"\nValor inválido para o lado C. Deve estar entre {minLadoC:F2} e {maxLadoC:F2}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nValor inválido para o lado C.");
                    }
                }
                else
                {
                    Console.WriteLine("\nValor inválido para o lado B.");
                }
            }
            else
            {
                Console.WriteLine("\nValor inválido para o lado A.");
            }
        }
    }
}
