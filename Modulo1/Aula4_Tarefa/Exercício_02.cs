
//// Exercício 2


//// IF ELSE

////1.1

//Console.WriteLine("Digite um número: ");
//int numeroA = int.Parse(Console.ReadLine());

//numeroA = numeroA % 2;
//if (numeroA == 0)
//{
//    Console.WriteLine("O número é par");
//}
//else
//{
//    Console.WriteLine("O número é ímpar");
//}

////1.2

//Console.WriteLine("Digite seu nome: ");
//string nome = Console.ReadLine();
//Console.WriteLine("Digite sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//if (idade < 18 || idade > 60)
//{
//    Console.WriteLine($"Olá {nome}, sua entradaserá barrada por motivos de segurança.");
//}
//else
//{
//    Console.WriteLine($"Olá {nome}, sua entrada foi liberada.");
//}

////Switch

////2.1

//Console.WriteLine("Digite um numero de 1 a 7: ");
//int diaSemana = int.Parse(Console.ReadLine());

//switch (diaSemana)
//{
//    case 1:
//        Console.WriteLine("Domingo");
//        break;
//    case 2:
//        Console.WriteLine("Segunda-feira");
//        break;
//    case 3:
//        Console.WriteLine("Terça-feira");
//        break;
//    case 4:
//        Console.WriteLine("Quarta-feira");
//        break;
//    case 5:
//        Console.WriteLine("Quinta-feira");
//        break;
//    case 6:
//        Console.WriteLine("Sexta-feira");
//        break;
//    case 7:
//        Console.WriteLine("Sábado");
//        break;
//    default:
//        Console.WriteLine("Número inválido, por favor digite um número de 1 a 7.");
//        break;
//}

////Arrays

////3.1 

//Console.WriteLine("Digite 5 valores numéricos: ");
//int[] numeros = new int[5];

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write($"Número {i + 1}: ");
//    numeros[i] = int.Parse(Console.ReadLine());
//}

////3.2 Escreva um programa que peça ao usuário 10 números e armazene-os em um Array. O programa deve identificar o maior e o menor número informado pelo usuário.

//Console.WriteLine("Digite 10 números: ");

//int[] numeros10 = new int[10];

//for (int i = 0; i < numeros10.Length; i++)
//{
//    Console.Write($"Número {i + 1}: ");
//    numeros10[i] = int.Parse(Console.ReadLine());
//}

//int maiorNumero = numeros10[0];

//for (int i = 1; i < numeros10.Length; i++)
//{
//    if (numeros10[i] > maiorNumero)
//    {
//        maiorNumero = numeros10[i];
//    }
//}

//Console.WriteLine($"O maior número informado é: {maiorNumero}");

////3.3

//Console.WriteLine("Digite 5 nomes: ");
//string[] nomes = new string[5];

//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.Write($"Nome {i + 1}: ");
//    nomes[i] = Console.ReadLine();
//}

//Console.WriteLine("Os nomes informados foram (em ordem inversa): ");
//for (int i = nomes.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(nomes[i]);
//}

//Listas

//4.1 - Escreva um programa que peça ao usuário uma quantidade indeterminada de nomes. Ao final da execução, exiba todos os nomes informados pelo usuário (o gatilho para encerrar a coleta de nomes é escrever sair)

Console.WriteLine("Digite nomes (digite 'sair' para encerrar): ");

List<string> nomesLista = new List<string>() {""};
foreach (string nome in nomesLista)
{
    string nomeDigitado = Console.ReadLine();

    if (nomeDigitado.ToLower() == "sair")
    {
        break;
    }
    else
    {
        nomesLista.Add(nomeDigitado);
    }
}

//4.2

//For

//5.1

//5.2

//While

//6.1

//6.2

//Foreach

//7.1

// Do While

//8.1

