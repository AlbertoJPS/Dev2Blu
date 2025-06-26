namespace TarefasAula.MaosNaMassa
{
    public class PraticaSwith
    {
        public static void VerificarFila() 
        {
            Console.WriteLine("\n\nEstamos organizando os alunos para a foto de final de curso e para isso, \ndecidimos fazer três filas.");
            Console.WriteLine("\n\nPara comerçarmos, me diga seu nome, já que é o primeiro: \n");

            char primeiraLetraNome = Console.ReadLine()[0];

            switch (primeiraLetraNome)
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                    Console.WriteLine("\nPor favor dirija-se a Fila 02");
                    break;
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    Console.WriteLine("\nPor favor dirija-se a Fila 01");
                    break;
                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    Console.WriteLine("\nPor favor dirija-se a Fila 03");
                    break;
                default:
                    Console.WriteLine("\nNome inválido.");
                    break;
            }

        }
    }
}
