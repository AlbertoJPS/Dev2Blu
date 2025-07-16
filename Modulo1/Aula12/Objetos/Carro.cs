
namespace Aula12.Objetos
{
    public class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public void Acelerar()
        {
            Console.Write("O carro está acelerando");
        }

        public void Acelerar(int pedal)
        {
            if (pedal <= 5)
            {
                Acelerar();
                Console.WriteLine(" lentamente!");
            }
            else if (pedal <= 100)
            {
                Acelerar();
                Console.WriteLine(" normalmente!");
            }
            else
            {
                Acelerar();
                Console.WriteLine(" loucamente! ;P");
            }
        }
    }
}
