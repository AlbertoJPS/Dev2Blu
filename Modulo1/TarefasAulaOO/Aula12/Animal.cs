namespace TarefasAulaOO.Aula12
{
    public class Animal
    {

        public static void Main(string[] args)
        {
            // Método Main vazio
        }

        private const int TAMANHO_BARRIGA = 5;

        private int _Saciedade = 0;

        private string _Nome = null;
        //public string Nome { get; set; }
        public string Nome { 
            get 
            {
                return _Nome.ToUpper();
            }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Nome = value;
                }
            }
        }
        public int NomeCientifico { get; set; }
        public int Idade { get; set; }

        public void Comer()
        {
            if (_Saciedade == TAMANHO_BARRIGA)
            {
                _Saciedade++;
                Console.WriteLine($"O {Nome} não está mais com fome.");
            }
            else
            {
                Console.WriteLine($"{Nome} já está satisfeito e não pode comer mais.");
            }
        }
    }
}
