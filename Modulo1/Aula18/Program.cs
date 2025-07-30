using Aula18;

//Abstração


var formas = new List<FormaGeometrica>()
{
    //new FormaGeometrica(), -> não é possivel instanciar diretamente a classe, devido ela ser abstrata
    new Circulo(5),
};

foreach (var forma in formas)
{
    Console.WriteLine(forma.ToString());
}

Console.ReadKey();