using static System.Net.Mime.MediaTypeNames;

Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("Exercício 1\n\n ");

SimulateTyping("A Jornada de Bob\n\n\n", 25);
Thread.Sleep(1000);

//Variáveis a serem usadas

bool comparativo = false;
string verificacao = "";
int valorResultado = 0;
int valorEntradaA = 0;
int valorEntradaB = 0;

SimulateTyping("Bob se aposentou bem e sempre preocupava em tentar ajudar o maximo que podia, \nmas não sabia o que esperava por ele neste dia.\n\n", 25);
SimulateTyping("Era uma manhã ensolarada e cheia de possibilidades...\n\n", 25);
SimulateTyping("Bob começou sua jornada, passo a passo.\n\n\n", 25);

//1 Operadores Aritméticos

SimulateTyping("Após andar um pouco pela mesma rua de sempre, \nele se deparou com uma pequena criança chorando no chão.\n\n", 25);
SimulateTyping("A criança entre soluços disse que o cachorro havia comido seu exercício de matemática, \ne que não poderia terminar a tempo, pois a aula já iria começar.\n\n", 25);
SimulateTyping("Bob então disse que o ajudaria a terminar a tarefa, e que ele não deveria mais chorar.\n", 25);
SimulateTyping("A criança então começou a dizer exercício por exercício.\n\n", 25);
Console.ResetColor();

//1.1

SimulateTyping("Diga dois números para Bob e ele somará para você.\n\n", 25);

Console.WriteLine("Escreva o primeiro número: ");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado = valorEntradaA + valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nJovem pronto para anotar? O resultado dessa soma é {valorResultado}\n\n", 25);
Console.ResetColor();


//1.2

SimulateTyping("Diga dois números para Bob e ele vai Subtrair para você.\n\n", 25);

Console.WriteLine("Escreva o primeiro número: ");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado = valorEntradaA - valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nO resultado dessa subtração é {valorResultado}\n\n", 25);
Console.ResetColor();

//1.3

SimulateTyping("Diga dois números para Bob e ele multiplicará para você.\n\n", 25);

Console.WriteLine("Escreva o primeiro número: ");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado = valorEntradaA * valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nO resultado dessa multiplicação é {valorResultado}\n\n", 25);
Console.ResetColor();

//1.4

SimulateTyping("Diga dois números para Bob e ele vai dividir para você.\n\n", 25);

Console.WriteLine("Escreva o primeiro número: ");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado = valorEntradaA / valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nO resultado dessa divisão é {valorResultado.ToString("D0")}\n\n", 25);
Console.ResetColor();

//1.5

SimulateTyping("Diga dois números para Bob e ele vai dividir e dizer qual o resto da divisão para você.\n\n", 25);

Console.WriteLine("Escreva o primeiro número: ");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado = valorEntradaA % valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nO resto resultante dessa divisão é {valorResultado}\n\n", 25);

SimulateTyping("A criança agradeceu muito e agora com um sorrizo no rosto saiu correndo para a escola,\n", 25);
SimulateTyping("Bob com um sentimento de realização, seguiu seu caminho.\n\n", 25);

//2 Operadores Atribuição

SimulateTyping("Mas ao longe já pode ver outro jovem pobre pedindo ajuda, e nínguem o ajudando, então foi até ele.\n", 25);
SimulateTyping("O jovem falou que não queria dinheiro, \nmas precisava de ajuda para comprar laranjas, para ele dar para as crianças que moravam na rua.\n\n", 25);
SimulateTyping("Bob pensou nas crianças passando fome...\n\n", 25); Thread.Sleep(2000);
Console.ResetColor();

//2.1

//total inicial de laranjas com menino pobre
valorEntradaA = 0;

Console.WriteLine("Quantas Laranjas comprará para o menino?");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado = valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nO menino ficou muito feliz com as {valorResultado} que deu a ele.\n\n", 25);


//2.2

SimulateTyping("Após recebe-las o menino abaixou a cabeça, e agradeceu, dizendo bem baixinho:\n", 25);
SimulateTyping("mas ainda não conseguirei alimentar a todos eles\n\n", 100);

SimulateTyping("Bob ouviu e o perguntou:\n\n", 25);
Console.ResetColor();

Console.WriteLine("Quantas Laranjas a mais você precisa?");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado += valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nO menino abriu um grande sorriso e disse que hoje eles teriam algo para comer,\nPois agora tinham {valorResultado} Laranjas.\n\n", 25);
Console.ResetColor();

//total de laranjas com menino pobre
valorEntradaA = valorResultado;

//2.3

SimulateTyping("O menino disse que tinha uma das crianças bem proximo, \ne se ele desse para ela, sem dúvidas ele ganharia o dia.\n\n", 25);
Console.ResetColor();

Console.WriteLine("Quantas dessas laranjas você quer levar para ela?");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado -= valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nPronto, com essas {valorResultado} Laranjas restantes eu levarei para os demais.\n\n", 25);


//2.4

SimulateTyping("Mas antes de ir Sr., queria saber se poderia me ajudar dessaforma mais alguns dias.\n", 25);
SimulateTyping("O Sr. com certeza sabe que poderia salvar muitas vidas assim, \nsão tantas crianças com fome que ajudaria a ter o que comer..\n", 25);
Console.ResetColor();

Console.WriteLine("Quantos dias poderá comprar laranjas?");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado *= valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nUAAU!! Com o senhos ajudando com {valorEntradaA} por {valorEntradaB} dias, teremos um total de {valorResultado} Laranjas esse mês.\n\n", 25);


//2.5

SimulateTyping(".....\n", 100);
SimulateTyping("Já que o senhor ainda está aqui, poderia me dar uma ultima ajuda?\nEu não sei quantas laranjas terei de dar para cada uma das crianças.", 25);
Console.ResetColor();

Console.WriteLine("\nVocê acha melhor dar quantas laranjas do total para cada uma da crianças?");
valorEntradaB = int.Parse(Console.ReadLine());

valorResultado /= valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nMuito obrigado por tudo Sr, farei como me disse e darei aproximadamente {valorResultado} Laranjas para cada.\n\n", 25);

//3 Operadores Relacionais

//3.1

SimulateTyping("Ao andar mais um pouco Bob estava pensando na vida, mas um artista de rua o parou \ne mostrou 2 jarros de vidro com muitas bolinhas.\n\n", 25);
SimulateTyping("Olá prezado Senhor, quantas bolinhas estão em cada jarro, será que tem a mesma quantidade?\n", 25);
Console.ResetColor();

Console.WriteLine("\nDiga o número de bolinhas no primeiro jarro");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("\nDiga o número de bolinhas no segundo jarro");
valorEntradaB = int.Parse(Console.ReadLine());

comparativo = valorEntradaA == valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\n{comparativo}, os dois jarros tem a mesma quantidade de bolinhas.\n\n", 25);

//3.2

SimulateTyping("Mas o show não terminou, os outros eram iguais, e agora? \nSerá esses 2 novos jarros também são iguais? Ou seria diferente?\n", 25);
Console.ResetColor();

Console.WriteLine("\nDiga o número de bolinhas no primeiro jarro");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("\nDiga o número de bolinhas no segundo jarro");
valorEntradaB = int.Parse(Console.ReadLine());

comparativo = valorEntradaA != valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\n{comparativo}, os dois jarros tem quantidades diferentes de bolinhas.\n\n", 25);

//3.3

SimulateTyping("E o que será agora? será que o primeiro jarro tem mais bolinhas que o segundo?\n", 25);
Console.ResetColor();

Console.WriteLine("\nDiga o número de bolinhas no primeiro jarro");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("\nDiga o número de bolinhas no segundo jarro");
valorEntradaB = int.Parse(Console.ReadLine());

comparativo = valorEntradaA > valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\n{comparativo}, o primeiro jarro tem mais bolinhas.\n\n", 25);

//3.4

SimulateTyping("Humm, e agora? será que o primeiro jarro tem menos bolinhas que o segundo?\n", 25);
Console.ResetColor();

Console.WriteLine("\nDiga o número de bolinhas no primeiro jarro");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("\nDiga o número de bolinhas no segundo jarro");
valorEntradaB = int.Parse(Console.ReadLine());

comparativo = valorEntradaA < valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\n{comparativo}, o primeiro jarro tem menos bolinhas que o segundo jarro.\n\n", 25);

//3.5

SimulateTyping("Agora atenção para nosso ultimo e mais dificil show!! \nEsses dois jarros são diferentes ou iguais?\n", 25);
SimulateTyping("O primeiro jarro tem mais bolinhas ou tem a mesma quantidade que o segundo ou não?\n", 25);
Console.ResetColor();

Console.WriteLine("\nDiga o número de bolinhas no primeiro jarro");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("\nDiga o número de bolinhas no segundo jarro");
valorEntradaB = int.Parse(Console.ReadLine());

comparativo = valorEntradaA >= valorEntradaB;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\n{comparativo}, Ahhh, Ele realmente é maior ou igual, então obrigado por participar!! .\n\n", 25);

SimulateTyping("\nO artista de rua agradeceu a todos, e eu segui meu caminho contente com a experiência.\n\n", 25);


//4 Operadores Lógicos

//4.1

SimulateTyping("\nBob chegou em uma encruzilhada, mas ele quer passar apenas por onde não tem poças de lama.\n", 25);
SimulateTyping("Mas se houver poças na esqueda e na direita ele irá pelo caminho do meio.\n", 25);
Console.ResetColor();

Console.WriteLine("\nDiga quantas poças tem na esquerda");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("Diga quantas poças tem na direita");
valorEntradaB = int.Parse(Console.ReadLine());

comparativo = valorEntradaA > 0 && valorEntradaB > 0;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nBob pensou e ele definiu: a afirmação de passar pela esquerda ou direita é {comparativo}.\n\n", 25);

//4.2

SimulateTyping("\nE ao andar um pouco mais chegou em uma bifurcação, \nNisso ele mudou de ideia e queria pisar na lama,\n", 25);
SimulateTyping("então em último recurso ele voltaria para casa. Já que a sua intenção era se divertir.\n", 25);
Console.ResetColor();

Console.WriteLine("\nDiga quantas poças tem na esquerda");
valorEntradaA = int.Parse(Console.ReadLine());
Console.WriteLine("Diga quantas poças tem na direita");
valorEntradaB = int.Parse(Console.ReadLine());

comparativo = valorEntradaA > 0 || valorEntradaB > 0;

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nBob pensou denovo e ele definiu: A afirmação de seguir em diante é {comparativo}.\n\n", 25);

//5 Operadores Ternários

//5.1

SimulateTyping("\nNa fim de seu percurso ele passou em um mercadinho para reabastecer as energias\n", 25);
SimulateTyping("mas ao comprar seu lanche, um jovem-adulto o chamou, e perguntou se poderia inteirar o valor da cerveja\n", 25);
SimulateTyping("para não cometer nenhum erro ele quis conferir se o jovem era maior de idade e pediu sua identidade.\n\n", 25);
Console.ResetColor();

Console.WriteLine("\nQuantos anos tem na sua identidade baseada na sua data de nascimento?");
valorEntradaA = int.Parse(Console.ReadLine());

verificacao = valorEntradaA >= 18 ? "maior de idade" : "menor de idade";

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nBob verificou e descobriu que ele é {verificacao}.\n\n", 25);

//5.2

SimulateTyping("Ele então chegou em uma sacola e colocou alguns, itens, mas por TOQUE, \nele contou os itens para ver se tinha uma quantidade par ou impar de itens, \njá que era muito superticioso\n\n", 25);
Console.ResetColor();

Console.WriteLine("\nQuantos itens tem na sacola");
valorEntradaA = int.Parse(Console.ReadLine());

valorEntradaB = valorEntradaA % 2;
verificacao = valorEntradaB == 1 ? "Ímpar" : "Par";

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nEle descobriu que o total de itens era {verificacao}.\n\n", 25);

//5.3

SimulateTyping("E com isso terminou suas compras\n\n", 25);
SimulateTyping("\nChegando no caixa ele olhou no celular e viu se poderia passar no crédito\n\n", 25);
Console.ResetColor();

Console.WriteLine("\nSua conta tinha quanto dinheiro? (permitido ser positivo ou negativo também)");
valorEntradaA = int.Parse(Console.ReadLine());

verificacao = valorEntradaA > 0 ? "Positivo" : valorEntradaA < 0 ? "Negativo" : "Zero";

Console.ForegroundColor = ConsoleColor.DarkYellow;
SimulateTyping($"\nAo olhar na sua conta seu credito estava em {verificacao}.\n\n", 25);
SimulateTyping("\nMas ele pensou mais um pouco e pagou no dinheiro mesmo.\n\nBob o aposentado saiu então da loja e terminou sua jornada de 1 dia\n", 25);




// Metodo de Simulador de digitação com atraso

static void SimulateTyping(string text, int delay)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(delay);
    }

    Thread.Sleep(500);
}