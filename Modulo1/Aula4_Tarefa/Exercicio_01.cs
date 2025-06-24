
Console.WriteLine("Exercício 1\n");


//1 Operadores Aritméticos

bool resultado;
int numero1 = 0;
int numero2 = 0;

//1.1
Console.WriteLine("Vou comparar se os dois números a seguir são iguais: ");

Console.WriteLine("Escreva o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultado = numero1 == numero2; 
Console.WriteLine($"Resultado = {resultado}");

//1.2
Console.WriteLine("Vou comparar se os dois números a seguir são diferentes: ");

Console.WriteLine("Escreva o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultado = numero1 == numero2;
Console.WriteLine($"Resultado = {!resultado}");

//1.3
Console.WriteLine("Vou comparar se o primeiro é maior que o segundo: ");

Console.WriteLine("Escreva o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultado = numero1 > numero2;
Console.WriteLine($"Resultado = {resultado}");

//1.4
Console.WriteLine("Vou comparar se o primeiro é menor que o segundo: ");

Console.WriteLine("Escreva o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultado = numero1 < numero2;
Console.WriteLine($"Resultado = {resultado}");

//1.5
Console.WriteLine("Vou comparar se o primeiro é maior ou igual ao segundo: ");

Console.WriteLine("Escreva o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultado = numero1 >= numero2;
Console.WriteLine($"Resultado = {resultado}");


//2 Operadores Atribuição

int numero0 = 20;

//2.1
Console.WriteLine("Eu tenho 20 laranjas, quantas você me dará? ");

Console.WriteLine("Escreva quantas laranjas vai doar: ");
numero1 = int.Parse(Console.ReadLine());

numero0 += numero1;
numero2 = numero1;
Console.WriteLine($"Agora eu tenho {numero0} Laranjas");

//2.2
Console.WriteLine($"Eu tinha 20 laranjas, você me deu {numero1} laranjas, \nMas são muitas bocas para alimentar, me daria mais algumas? ");

Console.WriteLine("Escreva quantas laranjas vai doar a mais: ");
numero1 = int.Parse(Console.ReadLine());

numero0 += numero1;
numero2 += numero1;
Console.WriteLine($"Uau!! Agora tenho {numero0} Laranjas");

//2.3
Console.WriteLine($"Eu tinha 20 laranjas passado, você foi bondoso e me deu {numero2} laranjas, e chegamos a um total de {numero0} laranjas,");
Console.WriteLine("Como você me doou tantas, preciso que me tire uma dúvida...");
Console.WriteLine("Quantas laranjas eu devo doar para essa primeira Familia?");

Console.WriteLine("Escreva quantas laranjas ele deve doar: ");
numero1 = int.Parse(Console.ReadLine());

numero0 -= numero1;
Console.WriteLine($"Doarei {numero1} e me restarão ainda {numero0} laranjas");

//2.4
Console.WriteLine("Fico muito Feliz, vou continuar ajudando outras famílias agora, mas antes de ir, ");
Console.WriteLine($"Queria saber se poderia me ajudar alguns dias com essa quantia de {numero2} Laranjas que me ajudou hoje?!");
Console.WriteLine("Quantos dias conseguiria me dar essa enorme ajuda que vai tirar a fome de tantas ciraças que não tem o que comer esse mês?");

Console.WriteLine("Escreva quantos dias vai doar: ");
numero1 = int.Parse(Console.ReadLine());

numero0 = numero1 * numero2;
Console.WriteLine($"Cara você é tão generoso, nesse mês você terá nos doado {numero0} Laranjas. Muito Obrigado");

//2.5
Console.WriteLine("Já que você ainda está aqui, se não for abusar da msua ajuda.. ");
Console.WriteLine("Eu queria saber em quantas casas quer que eu leve essas Laranjas?");
Console.WriteLine("Não são bom em logistica, então me ajudaria muito..");

Console.WriteLine("Escreva quantas casas se beneficiarão dessas laranjas doadas por você: ");
numero1 = int.Parse(Console.ReadLine());

numero2 = numero0 * numero1;
Console.WriteLine($"Cara você é tão generoso, nesse mês você terá nos doado {numero2} Laranjas. Muito Obrigado");


//3 Operadores Relacionais



//4 Operadores Lógicos

//4.1
Console.WriteLine("Vou comparar se ambos os números são maiores que zero: ");

Console.WriteLine("Escreva o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultado = numero1 > 0 && numero2 > 0;
Console.WriteLine($"Resultado = {resultado}");

//4.2
Console.WriteLine("Vou comparar se algum dos números são maiores que zero: ");

Console.WriteLine("Escreva o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

resultado = numero1 > 0 || numero2 > 0;
Console.WriteLine($"Resultado = {resultado}");

//5 Operadores Ternários


