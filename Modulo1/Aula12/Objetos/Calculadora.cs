

namespace Aula12.Objetos
{
    public class Calculadora
    {
        public void Somar(double a, double b)
        {
            double resultado = a + b;
            Console.WriteLine($"{a} + {b} = {resultado}");
        }

        public void Subtrair(double a, double b)
        {
            double resultado = a - b;
            Console.WriteLine($"{a} - {b} = {resultado}");
        }

        public void Multiplicar(double a, double b)
        {
            double resultado = a * b;
            Console.WriteLine($"{a} x {b} = {resultado}");
        }

        public void Dividir(double a, double b)
        {
            double resultado = a / b;
            Console.WriteLine($"{a} / {b} = {resultado}");
        }
    }
}
