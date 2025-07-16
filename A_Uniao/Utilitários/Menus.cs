
using Sistema_Central.Entities;

namespace Sistema_Central.Utilitários
{
    public static class Menus
    {

        public static void ExibirMenuInicial(List<Planeta> planetas, List<Nave> naves, List<Missao> missoes, List<Astronauta> astronautas)
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\n=====================================");
                Console.WriteLine("\n SISTEMA CENTRAL DE MISSÕES DA UNIÂO ");
                Console.WriteLine("\n=====================================\n");
                Console.WriteLine("1 - Cadastros");
                Console.WriteLine("2 - Exibir Informações");
                Console.WriteLine("3 - Requisitar Nova Missão");
                Console.WriteLine("4 - Lançar Missão");
                Console.WriteLine("5 - Avançar Dias");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("\n=====================================\n");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //ExibirMenuCadastros(planetas, naves, astronautas);
                        Console.ReadKey();
                        break;

                    case "2":
                        ExibirMenuListas(planetas, naves, missoes, astronautas);
                        Console.ReadKey();
                        break;

                    case "3":
                        Requisicao.RequisitarMissao(planetas, naves, missoes, astronautas);
                        Console.ReadKey();
                        break;

                    case "4":
                        Lancamento.LancarMissao(missoes, astronautas);
                        Console.ReadKey();
                        break;

                    case "5":
                        //AvançarDias(missoes, astronautas);
                        Console.ReadKey();
                        break;

                    case "0":
                        Console.WriteLine("\nEncerrando o sistema...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != "0");
        }
        public static void ExibirMenuListas(List<Planeta> planetas, List<Nave> naves, List<Missao> missoes, List<Astronauta> astronautas)
        {
            string? opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\n=====================================");
                Console.WriteLine("\n========= MENU DE LISTAGENS =========");
                Console.WriteLine("\n=====================================\n");
                Console.WriteLine("1 - Ver Planetas");
                Console.WriteLine("2 - Ver Naves");
                Console.WriteLine("3 - Ver Missões");
                Console.WriteLine("4 - Ver Astronautas");
                Console.WriteLine("0 - Voltar");
                Console.WriteLine("\n=====================================\n");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\n=====================================");
                        Console.WriteLine("\n========= LISTA DE PLANETAS =========");
                        Console.WriteLine("\n=====================================");
                        foreach (var planeta in planetas)
                        {
                            switch (planeta.SituacaoAtual)
                            {
                                case SituacaoPlaneta.Habitavel:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Planeta.MostrarPlaneta(planeta);
                                    Console.ResetColor();
                                    break;
                                case SituacaoPlaneta.Inexplorado:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Planeta.MostrarPlaneta(planeta);
                                    Console.ResetColor();
                                    break;
                                case SituacaoPlaneta.Hostil:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Planeta.MostrarPlaneta(planeta);
                                    Console.ResetColor();
                                    break;
                                case SituacaoPlaneta.FonteDeRecursos:
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Planeta.MostrarPlaneta(planeta);
                                    Console.ResetColor();
                                    break;
                            }
                        }
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n=====================================");
                        Console.WriteLine("\n========== LISTA DE NAVES ===========");
                        Console.WriteLine("\n=====================================");
                        foreach (var nave in naves)
                        {
                            switch (nave.EstadoAtualNave)
                            {
                                case SituacaoNave.Disponivel:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Nave.MostrarNave(nave);
                                    Console.ResetColor();
                                    break;
                                case SituacaoNave.EmMissao:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Nave.MostrarNave(nave);
                                    Console.ResetColor();
                                    break;
                                case SituacaoNave.Avariada:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Nave.MostrarNave(nave);
                                    Console.ResetColor();
                                    break;
                                case SituacaoNave.Perdida:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Nave.MostrarNave(nave);
                                    Console.ResetColor();
                                    break;
                            }
                        }
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("\n=====================================");
                        Console.WriteLine("\n========= LISTA DE MISSÕES ==========");
                        Console.WriteLine("\n=====================================");
                        foreach (var missao in missoes)
                        {
                            switch (missao.EstadoMissao)
                            {
                                case SituacaoMissao.Pendente:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Missao.MostrarMissoes(missao);
                                    Console.ResetColor();
                                    break;
                                case SituacaoMissao.EmAndamento:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Missao.MostrarMissoes(missao);
                                    Console.ResetColor();
                                    break;
                                case SituacaoMissao.Concluida:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Missao.MostrarMissoes(missao);
                                    Console.ResetColor();
                                    break;
                                case SituacaoMissao.Cancelada:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Missao.MostrarMissoes(missao);
                                    Console.ResetColor();
                                    break;
                                case SituacaoMissao.Falhou:
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Missao.MostrarMissoes(missao);
                                    Console.ResetColor();
                                    break;
                            }
                        }
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("\n=====================================");
                        Console.WriteLine("\n======== LISTA DE ASTRONAUTAS =======");
                        Console.WriteLine("\n=====================================");
                        foreach (var astronauta in astronautas)
                        {
                            switch (astronauta.EstadoAstronauta)
                            {
                                case SituacaoAstronauta.Disponivel:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Astronauta.MostrarAstronauta(astronauta);
                                    Console.ResetColor();
                                    break;
                                case SituacaoAstronauta.EmMissao:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Astronauta.MostrarAstronauta(astronauta);
                                    Console.ResetColor();
                                    break;
                                case SituacaoAstronauta.Ferido:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Astronauta.MostrarAstronauta(astronauta);
                                    Console.ResetColor();
                                    break;
                                case SituacaoAstronauta.Morto:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Astronauta.MostrarAstronauta(astronauta);
                                    Console.ResetColor();
                                    break;
                            }
                        }
                        Console.ReadKey();
                        break;

                    case "0":
                        Console.WriteLine("\nVoltando ao menu anterior...");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.");
                        break;
                }
            } while (opcao != "0");
        }
        
        
    }
}
