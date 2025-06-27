
// Exercício 2

//O Objetivo dessa lista é exercitar as instruções condicionais, de repetição, Arrays e Listas. 
//Resolva cada exercício utilizando pelo menos uma vez o conteúdo descrito na categoria das questões.

//Funcionou utilizando conteúdo descrito: 8 pontos
//Funcionou não utilizando conteúdo descrito: 2 pontos
//Avaliação de estrutura e lógica: 1 ponto
//Avaliação de proatividade e cuidados: 1 ponto


// IF ELSE

//1.1 Escreva um programa que peça para o usuário um número. 
//O programa deve informar ao usuário se o número é ímpar ou par

Console.WriteLine("\nIF ELSE----------------------------------------------------\n");

Console.WriteLine("\n\nDigite um número: ");

int numeroA = int.Parse(Console.ReadLine());

numeroA = numeroA % 2;
if (numeroA == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é ímpar");
}

Console.WriteLine("\n-----------------------------------------------------------\n");

//1.2 Escreva um programa que peça ao usuário o nome e a idade. 
//Caso o usuário seja menor de idade ou sua idade seja superior a 60 anos, 
//o programa deve indicar que sua entrada será barrada por normas de segurança.

Console.WriteLine("\n-----------------------------------------------------------\n");

Console.WriteLine("\nDigite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 18 || idade > 60)
{
    Console.WriteLine($"Olá {nome}, sua entradaserá barrada por motivos de segurança.");
}
else
{
    Console.WriteLine($"Olá {nome}, sua entrada foi liberada.");
}

Console.WriteLine("\n-----------------------------------------------------------\n");

//Switch

//2.1 Escreva um programa que peça ao usuário um número de 1 a 7 e após isso, 
//retorne o dia da semana correspondente a esse número. Exemplo: 1 == “Domingo”. 7 == “Sábado”.

Console.WriteLine("\nSwitch-----------------------------------------------------\n");

Console.WriteLine("\nDigite um numero de 1 a 7: \n");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    case 4:
        Console.WriteLine("Quarta-feira");
        break;
    case 5:
        Console.WriteLine("Quinta-feira");
        break;
    case 6:
        Console.WriteLine("Sexta-feira");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Número inválido, por favor digite um número de 1 a 7.");
        break;
}

Console.WriteLine("\n-----------------------------------------------------------\n");

//Arrays

//3.1 Escreva um programa que peça ao usuário 5 valores numéricos e armazene-os em um Array. 
//Calcule a soma de todos esses números e exiba o resultado na tela.

Console.WriteLine("\nArrays-----------------------------------------------------\n");

Console.WriteLine("\nDigite 5 valores numéricos: ");

int[] numeros = new int[5];
int soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    soma += numeros[i];
}

Console.WriteLine($"A soma dos números informados é: {soma}");

Console.WriteLine("\n-----------------------------------------------------------\n");

//3.2 Escreva um programa que peça ao usuário 10 números e armazene-os em um Array. 
//O programa deve identificar o maior e o menor número informado pelo usuário.

Console.WriteLine("\n-----------------------------------------------------------\n");

Console.WriteLine("\nDigite 10 números: ");

int[] numeros10 = new int[10];
int maiorNumero = numeros10[0];
int menorNumero = numeros10[0];

for (int i = 0; i < numeros10.Length; i++)
{
    Console.Write($"Número {i + 1}: ");

    numeros10[i] = int.Parse(Console.ReadLine());
}

for (int i = 1; i < numeros10.Length; i++)
{
    if (numeros10[i] > maiorNumero)
    {
        maiorNumero = numeros10[i];
    }
    if (numeros10[i] < menorNumero)
    {
        menorNumero = numeros10[i];
    }
}

Console.WriteLine($"O maior número informado é: {maiorNumero}\nE o menor número informado é: {menorNumero}");

Console.WriteLine("\n-----------------------------------------------------------\n");

//3.3 Escreva um programa que peça ao usuário 5 nomes e armazene-os em um Array. 
//Após isso exiba os nomes na ordem inversa da qual foram inseridos

Console.WriteLine("\n-----------------------------------------------------------\n");

Console.WriteLine("\nDigite 5 nomes: ");

string[] nomes = new string[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Nome {i + 1}: ");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine("\nOs nomes informados foram (em ordem inversa): ");

for (int i = nomes.Length - 1; i >= 0; i--)
{
    Console.Write($"Nome {i + 1}: {nomes[i]}");
}

Console.WriteLine("\n-----------------------------------------------------------\n");

//Listas

//4.1 Escreva um programa que peça ao usuário uma quantidade indeterminada de nomes.
//Ao final da execução, exiba todos os nomes informados pelo usuário 
//(Sinta-se à vontade para definir o gatilho desejado para encerrar a coleta de nomes).

Console.WriteLine("\nListas-----------------------------------------------------\n");

Console.WriteLine("\nDigite nomes (digite 'sair' para encerrar): ");

List<string> nomesLista = new List<string>();

while (true)
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

Console.WriteLine("\nOs nomes informados foram:");

foreach (string nomeInformados in nomesLista)
{
    Console.WriteLine(nomeInformados);
}

Console.WriteLine("\n-----------------------------------------------------------\n");

//4.2 Escreva um programa que possua uma lista com 10 número de sua preferência, os quais devem estar entre 1 e 100.
//Peça para o usuário informar um número de 1 a 100 e após isso verifique se o número está presente na lista criada inicialmente. 
//Dê três chances para o usuário acertar o máximo de números.

Console.WriteLine("\n-----------------------------------------------------------\n");

List<int> numerosPremiados = new List<int>() { 5, 12, 23, 34, 45, 56, 67, 78, 89, 90 };
int tentativas = 3;

Console.WriteLine("\nDigite um número de 1 a 100 (você tem 3 chances): ");
while (tentativas > 0)
{
    int numeroUsuario = int.Parse(Console.ReadLine());
    if (numerosPremiados.Contains(numeroUsuario))
    {
        Console.WriteLine("Parabéns! Você acertou um número premiado!!\nPara pegar seu premio digite todos os dados do seu cartão de crédito!!");
        Console.WriteLine("Incluindo os 3 numeros atrás do cartão");
        break;
    }
    else
    {
        tentativas--;

        if (tentativas > 0)
        {
            Console.WriteLine($"Número não encontrado. Você ainda tem {tentativas} tentativas.");
        }
        else
        {
            Console.WriteLine("Você esgotou suas tentativas. Tente novamente mais tarde.");
        }
    }
}

Console.WriteLine("\n-----------------------------------------------------------\n");

//For

//5.1 Escreva um programa que peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando um loop for. 
//Por exemplo: 5! = 5×4×3×2×1 = 120. 3! = 3×2×1 = 6. 0! = 1(por definição).

Console.WriteLine("\nFor--------------------------------------------------------\n");

Console.WriteLine("\nDigite um número inteiro positivo: ");
int numeroFatorial = int.Parse(Console.ReadLine());

int fatorial = 1;
for (int i = numeroFatorial; i > 0; i--)
{
    fatorial *= i;
}
Console.WriteLine($"O fatorial de {numeroFatorial}! é: {fatorial}");

Console.WriteLine("\n-----------------------------------------------------------\n");

//5.2 Escreva um programa que peça ao usuário um número e exiba a tabuada desse número para o usuário.

Console.WriteLine("\n-----------------------------------------------------------\n");

Console.WriteLine("\nDigite um número para ver sua tabuada: ");

int numeroTabuada = int.Parse(Console.ReadLine());

Console.WriteLine("\nSoma\n");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numeroTabuada} + {i} = {numeroTabuada + i}");
}

Console.WriteLine("\nSubtração\n");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numeroTabuada} - {i} = {numeroTabuada - i}");
}

Console.WriteLine("\nMultiplicação\n");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numeroTabuada} * {i} = {numeroTabuada * i}");
}

Console.WriteLine("\nDivisão (Inteiros)\n");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numeroTabuada} / {i} = {numeroTabuada / i}");
}

Console.WriteLine("\n-----------------------------------------------------------\n");

//While

//6.1 Escreva um programa que permita ao usuário inserir números indefinidamente até que um número negativo seja inserido.
//O programa deve calcular e exibir a soma de todos os números positivos inseridos.

Console.WriteLine("\nWhile------------------------------------------------------\n");

Console.WriteLine("\nDigite números (digite um número negativo para encerrar): ");
int numero = 0;
int somaNumeros = 0;

while (numero >= 0)
{
    numero = int.Parse(Console.ReadLine());

    if (numero >= 0)
    {
        somaNumeros += numero;
    }
}
Console.WriteLine($"A soma dos números positivos informados é: {somaNumeros}");

Console.WriteLine("\n-----------------------------------------------------------\n");

//6.2 Escreva um programa que permita ao usuário inserir números indefinidamente e conte quantos números pares foram inseridos.
//O programa deve parar quando o número 0 for inserido.

Console.WriteLine("\n-----------------------------------------------------------\n");

Console.WriteLine("\nDigite números (digite 0 para encerrar): ");
int numeroPar = 1;
int contadorPares = 0;

while (numeroPar != 0)
{
    numeroPar = int.Parse(Console.ReadLine());

    if (numeroPar % 2 == 0 && numeroPar != 0)
    {
        contadorPares++;
    }
}

Console.WriteLine($"\nVocê informou {contadorPares} números pares.");

Console.WriteLine("\n-----------------------------------------------------------\n");

//Foreach

Console.WriteLine("\nForeach----------------------------------------------------\n");

//7.1 Escreva um programa que declare uma lista com 5 nomes e exiba-os em tela.

List<string> listaDeNomes = new List<string>() { "Alberto", "Bruno", "Carlos", "Diana", "Marco" };

Console.WriteLine("\nLista de Nomes:\n");

foreach (string nomeDeclarados in listaDeNomes)
{
    Console.WriteLine(nomeDeclarados);
}

Console.WriteLine("\n-----------------------------------------------------------\n");

// Do While

//8.1 Simulação de caixa eletrônico
//Implemente as devidas regras de negócio para cada função.
//O menu deve continuar sendo exibido até que o usuário deseje sair.

decimal saldo = 0;
int opcao = 0;

do
{
    Console.Clear();
    Console.WriteLine("\nDo While---------------------------------------------------\n");

    Console.WriteLine("Banco +Devs2Blu, seja bem-vindo!\n");
    Console.WriteLine("1 - Consultar saldo");
    Console.WriteLine("2 - Realizar depósito");
    Console.WriteLine("3 - Realizar saque");
    Console.WriteLine("4 - Sair");

    Console.WriteLine("\n-----------------------------------------------------------\n");

    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"\n\nSeu saldo atual é: R$ {saldo:F2}");
            break;

        case 2:
            Console.Write("\n\nDigite o valor para depósito: R$ ");
            decimal deposito = decimal.Parse(Console.ReadLine());

            if (deposito > 0)
            {
                saldo += deposito;
                Console.WriteLine($"\nDepósito de R$ {deposito:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("\nValor inválido para depósito.");
            }
            break;

        case 3:
            Console.Write("\n\nDigite o valor para saque: R$ ");
            decimal saque = decimal.Parse(Console.ReadLine());

            if (saque > 0 && saque <= saldo)
            {
                saldo -= saque;
                Console.WriteLine($"\nSaque de R$ {saque:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("\nSaque inválido ou saldo insuficiente.");
            }
            break;

        case 4:
            Console.WriteLine("\n\nObrigado por utilizar o Banco +Devs2Blu. Volte sempre!");
            break;

        default:
            Console.WriteLine("\n\nOpção inválida. Tente novamente.");
            break;
    }

    if (opcao != 4)
    {
        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

} while (opcao != 4);

