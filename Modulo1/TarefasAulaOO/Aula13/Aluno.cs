
namespace TarefasAulaOO.Aula13
{
    public class Aluno
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Matricula { get; set; }

        public Aluno() { }

        public Aluno(string nome, int idade, string matricula)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
        }

        public void CalcularIdadeEmMeses()
        {
            int idadeEmMeses = Idade * 12;

            Console.WriteLine($"A idade de {Nome} em meses é: {idadeEmMeses}");
        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Matrícula: {Matricula}");
        }
    }
}
