
namespace Aula18
{
    internal abstract class FormaGeometrica
    {
        public abstract string Nome { get; }

        public abstract double CalcularPerimetro();
        public abstract double CalcularArea();

        public override string ToString()
        {
            switch(Nome)
            {
                case "círculo":
                    Console.ForegroundColor = ConsoleColor.Green;
                    return $"\no O {Nome} tem raio de {((Circulo)this).Raio}, perímetro de {CalcularPerimetro()} e área de {CalcularArea()}. o";
                case "retângulo":
                    Console.ForegroundColor = ConsoleColor.Red;
                    return $"\n▬ O {Nome} tem largura de {((Retangulo)this).Largura}, altura de {((Retangulo)this).Altura}, perímetro de {CalcularPerimetro()} e área de {CalcularArea()}. ▬";
                case "triângulo":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    return $"\n▲ O {Nome} tem lados de {((Triangulo)this).LadoA}, {((Triangulo)this).LadoB} e {((Triangulo)this).LadoC}, perímetro de {CalcularPerimetro()} e área de {CalcularArea()}. ▲";
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    return $"\nA forma geométrica {Nome} não é reconhecida.";

            }
        }
    }
}
