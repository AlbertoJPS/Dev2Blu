using Aula18;



//Abstração


//var formas = new List<FormaGeometrica>()
//{
//    //new FormaGeometrica(), -> não é possivel instanciar diretamente a classe, devido ela ser abstrata
//    new Circulo(5),
//};

//foreach (var forma in formas)
//{
//    Console.WriteLine(forma.ToString());
//}

//Console.ReadKey();
Console.WriteLine("\n=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
Console.WriteLine("Exercício de Abstração de Formas Geométricas");
Console.WriteLine("\n=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
Console.WriteLine("\nExemplos:");

var formas = new List<FormaGeometrica>()
{
    new Circulo(5),
    new Retangulo(10, 20),
    new Triangulo(3, 4, 5)
};

foreach (var forma in formas)
{
    Console.WriteLine(forma.ToString());
}
Console.ResetColor();

Console.WriteLine("\n=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
Console.WriteLine("Agora escolha a forma geométrica que quer calcular:");
Console.WriteLine("\n=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("1 - Círculo   (o)");
Console.WriteLine("2 - Retângulo (▬)");
Console.WriteLine("3 - Triângulo (▲)");
Console.ResetColor();
Console.WriteLine("\n=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

string continuar;

do
{
    Console.Write("\nDigite o número da forma geométrica: ");
    var escolha = Console.ReadLine();
    FormaGeometrica formaEscolhida = null;

    switch (escolha)
    {
        case "1":
            Circulo.OpcaoCirculo();
            break;

        case "2":
            Retangulo.OpcaoRetangulo();
            break;

        case "3":
            Triangulo.OpcaoTriangulo();
            break;

        default:
            Console.WriteLine("\nOpção inválida. Por favor, escolha 1, 2 ou 3.");
            break;
    }
    Console.ResetColor();

    Console.Write("\nQuer calcular outra forma? (s/n): ");
    continuar = Console.ReadLine()?.Trim().ToLower();

} while (continuar == "s");

Console.WriteLine("\nPrograma encerrado. Obrigado!");



