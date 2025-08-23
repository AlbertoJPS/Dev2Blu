
using System.Threading.Tasks.Dataflow;

//CLASSE PascalCase

//CONST SNAKE_CASE
const int NUMERO_MAXIMO_JOGADORES = 2;
const int NUMERO_MINIMO_JOGADORES = 6;

//VARIÁVEL CAMEL_CASE
string nomeJogo = "RPG";

Console.WriteLine("\nAntes de Começarmos gostaria de confirmar sua idade, qual sua data de nascimento?\n");

Console.Write("Dia: ");
Console.ForegroundColor = ConsoleColor.Green;
var diaTexto = Console.ReadLine();
Console.ResetColor();

Console.Write("Mês: ");
Console.ForegroundColor = ConsoleColor.Green;
var mesTexto = Console.ReadLine();
Console.ResetColor();

Console.Write("Ano: ");
Console.ForegroundColor = ConsoleColor.Green;
var anoTexto = Console.ReadLine();
Console.ResetColor();

int dia = int.Parse(diaTexto);
int mes = int.Parse(mesTexto);
int ano = int.Parse(anoTexto);

var dataNascimento = new DateTime(ano, mes, dia); // Cria um objeto DateTime com a data de nascimento

Console.WriteLine($"\nSua data de Nascimento é: {dataNascimento.ToString("dd/MM/yyyy")}");


Console.WriteLine("\nBoa noite jogador!\n\nQual o nome de sua partida de RPG?\n");

Console.ForegroundColor = ConsoleColor.Green;
string nomePartida = Console.ReadLine();
Console.ResetColor();

Console.WriteLine("\nMuito interessante, e para sua partida de" + nomeJogo + " de " + nomePartida + ". \nQual será o Nome do Mestre, e o número de jogadores? (pode me enviar 1 de cada vez)\n");

Console.ForegroundColor = ConsoleColor.Green;
string nomeMestre = Console.ReadLine();
int numeroJogadores = 0;
numeroJogadores = int.Parse(Console.ReadLine());
Console.ResetColor();

DateTime dataInicio = DateTime.Now; // Captura a data e hora atual

Console.WriteLine("\nMuito bem, " + nomeMestre + ".\n\nVocê terá " + numeroJogadores + " jogadores na sua partida de " + nomeJogo + " de " + nomePartida + ".\n\nBoa sorte e divirta-se!\nSua partida iniciou em: " + dataInicio + ".");

//Operadores Aritméticos

Console.WriteLine($"\nFarei alguns calculos para fixar seus conhecimentos de Operadores Aritiméticos.\n");

Console.WriteLine($"5 + 7 = {5 + 7}"); // Adição - resultado 12
Console.WriteLine($"5 - 7 = {5 - 7}"); // Subtração - resultado -2
Console.WriteLine($"5 * 7 = {5 * 7}"); // Multiplicação - resultado 35
Console.WriteLine($"10 / 3 = {10.0 / 3.0}"); // Divisão // resultado 3.33333333333333
Console.WriteLine($"10 % 3 = {10 % 3}"); // Módulo (resto da divisão) // resultado 1

//Operadores de Atribuição

Console.WriteLine($"\nFarei alguns calculos para também fixar seus conhecimentos de Operadores de Atribuição.\n");

var b = 10;  //=> 10 
Console.WriteLine($"\n{b}\n"); // Exibe o valor inicial de b - resultado 10
b = 20; //=> 20
Console.WriteLine($"\n{b}\n"); // Atribuição de novo valor a b - resultado 20
b += 10;  //=> 30
Console.WriteLine($"\n{b}\n"); // Atribuição de soma - resultado 30
b -= 5;  //=> 25
Console.WriteLine($"\n{b}\n"); // Atribuição de subtração - resultado 25
b *= 10; //=> 250
Console.WriteLine($"\n{b}\n"); // Atribuição de multiplicação - resultado 250
b /= 2; //=> 125
Console.WriteLine($"\n{b}\n"); // Atribuição de divisão - resultado 125
b %= 2; //=> 1
Console.WriteLine($"\n{b}\n"); // Atribuição de módulo (resto da divisão) - resultado 1
b++; //=> 2
Console.WriteLine($"\n{b}\n"); // Incremento de b - resultado 2
b--; //=> 1
Console.WriteLine($"\n{b}\n"); // Decremento de b - resultado 1


var resultado = 10.3 / 6.36; // resultado da divisão de dois números decimais = > 1.62037037037037
Console.WriteLine($"\n{resultado}\n"); // Exibe o resultado da divisão sem formatação
Console.WriteLine($"\n{resultado.ToString("F2")}\n"); // Formatação de número com duas casas decimais - resultado 1.62

//https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

var numeroInteiro = 23;
Console.WriteLine($"\n{numeroInteiro++} - Usuário\n"); // Incrementa o valor de numeroInteiro e exibe o valor antes do incremento
Console.WriteLine($"\n{++numeroInteiro} - Usuário\n"); // Incrementa o valor de numeroInteiro e exibe o valor após o incremento
// incremento pós-fixado e pré-fixado não são boas práticas em produção, pois podem causar confusão. 
Console.WriteLine($"\n{numeroInteiro.ToString("D5")} - Usuário\n"); // Formatação de número inteiro com 5 dígitos, preenchendo com zeros à esquerda


//Operadores Relacionais

Console.WriteLine($"\nFarei alguns calculos para também fixar seus conhecimentos de Operadores Relaionais.\n");

Console.WriteLine($"5 == 7: {5 == 7}"); // Igualdade - resultado falso
Console.WriteLine($"5 != 7: {5 != 7}"); // Diferença - resultado verdadeiro
Console.WriteLine($"5 > 7: {5 > 7}"); // Maior que - resultado falso
Console.WriteLine($"5 < 7: {5 < 7}"); // Menor que - resultado verdadeiro
Console.WriteLine($"5 >= 7: {5 >= 7}"); // Maior ou igual a - resultado falso
Console.WriteLine($"5 <= 7: {5 <= 7}"); // Menor ou igual a - resultado verdadeiro


//Operadores Lógicos

Console.WriteLine($"\nFarei alguns calculos para também fixar seus conhecimentos de Operadores Lógicos.\n");

Console.WriteLine($"(5 > 3) && (7 < 10): {(5 > 3) && (7 < 10)}"); // AND (verdadeiro e verdadeiro) - resultado verdadeiro
Console.WriteLine($"(5 > 3) || (7 > 10): {(5 > 3) || (7 > 10)}"); // OR (verdadeiro ou falso) - resultado verdadeiro
Console.WriteLine($"!(5 > 3): {!(5 > 3)}"); // NOT (verdadeiro (inverte o resultado)) - resultado falso

//Tabela Verdade
// https://pt.wikipedia.org/wiki/Tabela_verdade

// Tabela Verdade - Operadores Lógicos:
/*
Operador AND (&&):
 A      B     A && B
--------------------------------
 true   true     true
 true   false    false
 false  true     false
 false  false    false

Operador OR (||):
 A      B     A || B
--------------------------------
 true   true     true
 true   false    true
 false  true     true
 false  false    false

Operador NOT (!):
 A      !A
-----------------
 true   false
 false  true
*/

//Operador Ternário

Console.WriteLine($"\nFarei alguns calculos para também fixar seus conhecimentos de Operador Ternário.\n");

int idade = 23;
string resultadoIdade = idade >= 18 ? "maior de idade" : "menor de idade"; // Resultado = "maior de idade"
//variavel = condição ? valor_se_verdadeiro : valor_se_falso
