using TarefasAula.MaosNaMassa;


// Switch Case -------------------------------------------------



//char letra = 'A';

//Console.WriteLine("Digite uma letra: ");
//letra = Console.ReadLine()[0];

//switch (letra)
//{
//    case 'A':
//    case 'B':
//        Console.WriteLine("A letra é a letra A ou B");
//        break;
//    case 'F':
//        Console.WriteLine("A letra é a F");
//        break;
//    default:
//        Console.WriteLine("A letra eu não conheço");
//        break;
//}

//PraticaSwith.VerificarFila();


//Arrays -------------------------------------------------

// Console.WriteLine(nomes); // não imprime os nomes, apenas o endereço de memória

//--------------------------------------------------------------------

// Desafio opcional, aumentar o array com nomes já preenchidos

//string[] nomes = new string[] { "Marco" };

//nomes[nomes.Length + 1] = "Alberto";// não deu certo
//nomes[1] = "Alberto"; não deu certo
//nomes.Append("Alberto").ToArray(); //não deu certo
//nomes = nomes.Append("Alberto").ToArray();// deu certo, mais ainda não é isso
//...

//for (int i = 0; i < nomes.Length; i++)
//{ 
//    Console.WriteLine(nomes[i]);
//}
//--------------------------------------------------------------------


//PraticaArray.EscreverNotas();


// Listas -------------------------------------------------

List<string> listaAlunos = new List<string>();

listaAlunos.Add("Marco");
listaAlunos.Remove("Marco");

listaAlunos.Add("Alberto");
listaAlunos.Add("Ana");
listaAlunos.Add("João");
listaAlunos.Add("Marco");

int contador = 0;

foreach (string alunos in listaAlunos)
{
    contador++;
    Console.WriteLine($"{contador} - {alunos}");
}