

using System.Text;

Console.WriteLine("----------------------------------\n");
Console.WriteLine("Olá, como vai?\n\nCom quem estou conversando?\n");

Console.Write("Nome: ");
Console.ForegroundColor = ConsoleColor.Green;
string nome = Console.ReadLine();
Console.ResetColor();

Console.WriteLine("\nMuito prazer " + nome + ".\n\nE quantos anos você tem?\n");

Console.Write("Idade: ");
Console.ForegroundColor = ConsoleColor.Green;
string idade = Console.ReadLine();
Console.ResetColor();

Console.WriteLine("\nEu me chamo C# e tenho 23 anos.\n\nSerá um prazer codar com você ;)");

//Concatenação: Tipo 1

Console.WriteLine("\nAntes, quero te conhecer um pouco MAIS!\n\nQual seu Sobrenome?\n");

Console.Write("Sobrenome: ");
Console.ForegroundColor = ConsoleColor.Green;
string sobrenome = Console.ReadLine();
Console.ResetColor();

string nomeCompleto = (nome + " " + sobrenome);
Console.WriteLine("\nHumm, começarei a te chamar então com seu nome completo: "+ nomeCompleto);

//Concatenação: Tipo 2

string nomes = string.Format("\nMas não quero ser tão inoportuna. \n\nPor isso queria saber se prefere que eu o chame de \n\n{0}, de {1}, ou de {2}\n", nome, sobrenome, nomeCompleto);
Console.WriteLine(nomes);

// não funciona vvvvv
//Console.WriteLine("\n Mas não quero ser tão inoportuna, \npor isso queria saber se prefere que eu o chame de \n{0}, ou de {1}", nome, sobrenome);


bool valido = false;
string nomeEscolhido = " ";

//Concatenação: Tipo 3

while (!valido)
{
    Console.Write("Escolha: ");
    Console.ForegroundColor = ConsoleColor.Green;
    nomeEscolhido = Console.ReadLine();
    Console.ResetColor();

    if (nomeEscolhido == nome || nomeEscolhido == sobrenome || nomeEscolhido == nomeCompleto)
    {
        valido = true;
    }
    else
    {
        Console.WriteLine("\nDesculpe, não reconheci essa opção. Tente novamente usando exatamente como apresentado.\n");
    }
}

nomes = $"\n\nPerfeito! Então vou te chamar de {nomeEscolhido} daqui pra frente ;)";
Console.WriteLine(nomes);

Console.WriteLine("\nMuito Bem!! Vamos Revisar o que sabemos até agora.\n\n");

// StringBuilder

var sb = new StringBuilder();
sb.AppendLine("Dados do Desenvolvedor\n");
sb.AppendLine($"Nome: {nomeCompleto}");
sb.AppendLine($"Apelido: {nomeEscolhido}");
sb.AppendLine($"Idade: {idade}\n");

Console.WriteLine(sb.ToString());

Console.WriteLine("\n----------------------------------");




