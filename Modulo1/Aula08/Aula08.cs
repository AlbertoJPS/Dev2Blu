using TarefasAula.MaosNaMassa;

//// While

//PraticaWhile.ExecutarWhile();

//// TryParse + While

//PraticaTryParse.ExecutaTryParse();

//// Do While

//string aluno;
//bool continua = false;
//var alunos = new List<string>();

//do
//{
//    Console.WriteLine("Informe o nome do aluno (ou digite 'ok' para encerrar):");
//    aluno = Console.ReadLine();

//    if (aluno.ToLower() != "ok")
//    {
//        alunos.Add(aluno);
//        continua = true;
//    }
//    else
//    {
//        continua = false;
//    }
//} while (aluno.ToLower() != "ok");

//Console.WriteLine("Lista de alunos:");

//foreach (var item in alunos)
//{
//    Console.WriteLine(item);
//}

//PraticaDoWhile.ExecutarDoWhile();

// Foreach (reforço)

//List<string> carros = new List<string>() { "Uno", "Celta", "Corsa", "Fusca" };

//int count = 0;

//foreach (string modeloCarro in carros)
//{
//    count++;
//    Console.WriteLine($"\nCarro {count}: {modeloCarro}");
//}

PraticaForeach.ExecutarForeach();