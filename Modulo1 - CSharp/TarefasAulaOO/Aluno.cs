namespace TarefasAulaOO
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Matricula { get; private set; }

        static void Main(string[] args)
        {
        }

        public Aluno(string nome, int idade, DateTime nascimento)
        {
            Nome = nome;
            Idade = idade;
            Nascimento = nascimento;
        }

        public Aluno(string nome, int idade, DateTime nascimento, string matricula)
        {
            Nome = nome;
            Idade = idade;
            Nascimento = nascimento;
            Matricula = matricula;
        }

        public static Aluno CadastraAluno(List<Aluno> listaAlunos)
        {
            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Informe a idade do aluno: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a data de nascimento (dd/mm/yyyy): ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe a matrícula do aluno ou deixe em branco: ");
            string matricula = Console.ReadLine();

            Aluno aluno;
            if (string.IsNullOrWhiteSpace(matricula))
            {
                aluno = new Aluno(nome, idade, nascimento);
            }
            else
            {
                aluno = new Aluno(nome, idade, nascimento, matricula);
            }

            listaAlunos.Add(aluno);
            return aluno;
        }
        public void CalcularIdadeEmMeses()
        {
            DateTime hoje = DateTime.Today;
            int idadeMeses = (hoje.Year - Nascimento.Year) * 12 + (hoje.Month - Nascimento.Month);
            if (hoje.Day < Nascimento.Day)
            {
                idadeMeses--;
            }
            Console.WriteLine($"A idade em meses do aluno {Nome} é {idadeMeses}");
        }

        public void ExibirInfo()
        {
            Console.WriteLine("Informações do aluno");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            if (Matricula == string.Empty)
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=");
            }
            else
            {
                Console.WriteLine($"Matrícula: {Matricula}");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=");
            }
        }       
    }
}
