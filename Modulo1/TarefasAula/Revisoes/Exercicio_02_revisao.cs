

namespace TarefasAula.Revisoes
{ 
    public class Exercicio_02_revisao
    {
        public static void Array2()
        {
            //3.2 Escreva um programa que peça ao usuário 10 números e armazene-os em um Array. 
            //O programa deve identificar o maior e o menor número informado pelo usuário.

            Console.WriteLine("\n-----------------------------------------------------------\n");

            Console.WriteLine("\nDigite 10 números: ");

            int[] numeros10 = new int[10];
            int maiorNumero = int.MinValue;
            int menorNumero = int.MaxValue;

            for (int i = 0; i < numeros10.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");

                var numero = int.Parse(Console.ReadLine());

                numeros10[i] = numero;
                maiorNumero = numero > maiorNumero ? numero : maiorNumero;
                menorNumero = numero < menorNumero ? numero : menorNumero;

            }

            Console.WriteLine($"O maior número informado é: {maiorNumero}\nE o menor número informado é: {menorNumero}");

            Console.WriteLine("\n-----------------------------------------------------------\n");
        }

        public static void Array3()
        {
            //3.3 Escreva um programa que peça ao usuário 5 nomes e armazene-os em um Array. 
            //Após isso exiba os nomes na ordem inversa da qual foram inseridos

            Console.WriteLine("\n-----------------------------------------------------------\n");

            Console.WriteLine("\nDigite 5 nomes: ");

            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                var nome = Console.ReadLine();

                nomes[i] = nome;
            }

            Console.WriteLine("\nOs nomes informados foram (em ordem inversa): ");

            for (int i = nomes.Length - 1; i >= 0; i--)
            {
                Console.Write($"Nome {i + 1}: {nomes[i]}");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");
        }
        public static void List2()
        {
            Console.WriteLine("\n-----------------------------------------------------------\n");

            List<int> numerosPremiados = new List<int>() { 5, 12, 23, 34, 45, 56, 67, 78, 89, 90 };
            int tentativas = 3;

            Console.WriteLine("\nDigite um número de 1 a 100 (você tem 3 chances): ");
            while (tentativas > 0)
            {
                int numeroUsuario = int.Parse(Console.ReadLine());

                if (numerosPremiados.Contains(numeroUsuario))

                {
                    Console.WriteLine("Parabéns! Você acertou um número premiado!!\nPara pegar seu premio digite todos os dados do seu cartão de crédito!!");
                    Console.WriteLine("Incluindo os 3 números atrás do cartão");
                    break;
                }
                else if (numeroUsuario < 1 || numeroUsuario > 100)
                {
                    Console.WriteLine("Número inválido, você perdeu uma tentativa...");
                    tentativas--;
                }
                else
                {
                    tentativas--;

                        if (tentativas > 0)
                        {
                            Console.WriteLine($"Número não encontrado. Você ainda tem {tentativas} tentativas.");
                        }
                        else
                        {
                            Console.WriteLine("Você esgotou suas tentativas. Tente novamente mais tarde.");
                        }
                }
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");
        }
        public static void For1()
        {
            //5.1 Versão que calcula o fatorial multiplicando do maior para o menor.
            Console.WriteLine("\nFor Descending--------------------------------------------------------\n");

            Console.WriteLine("\nDigite um número inteiro positivo: ");
            int numeroFatorial = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = numeroFatorial; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} x {i}");
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {numeroFatorial}! é: {fatorial}");
            Console.WriteLine("\n-----------------------------------------------------------\n");
        }

        public static void DoWhile1() 
        {
            //8.1 Simulação de caixa eletrônico
            //Implemente as devidas regras de negócio para cada função.
            //O menu deve continuar sendo exibido até que o usuário deseje sair.

            decimal saldo = 0;
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\nDo While---------------------------------------------------\n");

                Console.WriteLine("Banco +Devs2Blu, seja bem-vindo!\n");
                Console.WriteLine("1 - Consultar saldo");
                Console.WriteLine("2 - Realizar depósito");
                Console.WriteLine("3 - Realizar saque");
                Console.WriteLine("4 - Sair");

                Console.WriteLine("\n-----------------------------------------------------------\n");

                Console.Write("Escolha uma opção: ");

                var escolha = Console.ReadLine();
                bool escolhaValida = int.TryParse(escolha, out opcao);

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"\n\nSeu saldo atual é: R$ {saldo:F2}");
                        break;

                    case 2:
                        Console.Write("\n\nDigite o valor para depósito: R$ ");
                        var depositoEntrada = Console.ReadLine();
                        bool depositoRealizado = decimal.TryParse(depositoEntrada, out decimal deposito);

                        if (deposito > 0)
                        {
                            saldo += deposito;
                            Console.WriteLine($"\nDepósito de R$ {deposito:F2} realizado com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("\nValor inválido para depósito.");
                        }
                        break;

                    case 3:
                        Console.Write("\n\nDigite o valor para saque: R$ ");
                        var saqueEntrada = Console.ReadLine();
                        bool saqueRealizado = decimal.TryParse(saqueEntrada, out decimal saque);

                        if (saque > 0 && saque <= saldo)
                        {
                            saldo -= saque;
                            Console.WriteLine($"\nSaque de R$ {saque:F2} realizado com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("\nSaque inválido ou saldo insuficiente.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n\nObrigado por utilizar o Banco +Devs2Blu. Volte sempre!");
                        break;

                    default:
                        Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                        break;
                }

                if (opcao != 4)
                {
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 4);

        }
    }
}
