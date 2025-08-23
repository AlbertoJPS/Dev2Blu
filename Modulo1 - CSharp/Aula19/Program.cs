using Aula19;
using Aula19.Interfaces;

//Interface
// A interface define como um padão de comportamento que as classes devem seguir.
// As classes abstratas em contraste, podem fornecer implementações parciais ou completas de métodos mas em nível de programação (para jogos seria como liberar para mod)

//List<IMotorizado> motorizados = new List<IMotorizado>();

//motorizados.Add(new Carro { Marca = "Fiat", Modelo = "Uno", Ano = 2020 });

//foreach (var motorizado in motorizados)
//{
//    motorizado.Ligar();
//    motorizado.Temperatura = 90;
//    Console.WriteLine($"Temperatura do veículo: {motorizado.Temperatura}°C");
//    motorizado.Desligar();
//}

//Console.WriteLine("Todos os veículos foram processados.");


// --------------------------------------------------------------
// Mão na Massa
// --------------------------------------------------------------

//int escolha;

//do
//{
//    Console.Clear();
//    Console.WriteLine("\n=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
//    Console.WriteLine("-=-=-=-=-=-=-=-=Bem vindo ao Sistema=-=-=-=-=-=-=-=-");
//    Console.WriteLine("=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
//    Console.ForegroundColor = ConsoleColor.DarkYellow;
//    Console.WriteLine("1 - Cadastrar Usuário");
//    Console.WriteLine("2 - Logar");
//    Console.WriteLine("3 - Sair");
//    Console.ResetColor();
//    Console.WriteLine("\n=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

//    Console.Write("\nDigite o número da opção escolhida: ");
//    bool valido = int.TryParse(Console.ReadLine(), out escolha);

//    if (!valido || escolha < 1 || escolha > 3)
//    {
//        Console.WriteLine("\nOpção inválida. Tente novamente.");
//        Console.ReadKey();
//        continue;
//    }

//    switch (escolha)
//    {
//        case 1:
//            CadastrarNovoUsuario();
//            break;
//        case 2:
//            Logar();
//            break;
//        case 3:
//            Console.WriteLine("\nSaindo do sistema...");
//            break;
//    }

//} while (escolha != 3);

//Console.WriteLine("\nPrograma encerrado. Obrigado!");

//void CadastrarNovoUsuario()
//{
//    Console.Clear();
//    Console.WriteLine("=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
//    Console.WriteLine("-=-=-=-=-=-=-=-=Sistema de Cadastro=-=-=-=-=-=-=-=-");
//    Console.WriteLine("=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

//    while (true)
//    {
//        UsuarioSistema usuario = new UsuarioSistema();
//        usuario.CadastrarUsuario();

//        Console.WriteLine("\nDeseja cadastrar outro usuário? (s/n)");
//        string resposta = Console.ReadLine()?.ToLower();
//        if (resposta != "s")
//        {
//            break;
//        }
//    }
//}

//void Logar()
//{
//    Console.Clear();
//    Console.WriteLine("=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
//    Console.WriteLine("-=-=-=-=-=-=-=-=Sistema de Login=-=-=-=-=-=-=-=-=-=");
//    Console.WriteLine("=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

//    if (UsuarioSistema._UsuarioSistemas.Count == 0)
//    {
//        Console.WriteLine("Nenhum usuário cadastrado. Por favor, cadastre um usuário primeiro.");
//        return;
//    }
//    else
//    {
//        UsuarioSistema usuarioCadastrado = new UsuarioSistema();
//        usuarioCadastrado.Autenticar();
//        _UsuarioLogado = usuarioCadastrado;
//        SistemaLogado(usuarioCadastrado);
//    }

//    Console.ReadKey();
//}
//void SistemaLogado(UsuarioSistema usuarioLogado)
//{
//    Console.Clear();
//    Console.WriteLine("=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
//    Console.WriteLine("-=-=-=-=-=-=-=-=Sistema Logado=-=-=-=-=-=-=-=-=-=-=");
//    Console.WriteLine("=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
//    Console.WriteLine($"Bem-vindo {usuarioLogado.UserName}! Você está logado.");

//    Console.WriteLine("\nPressione qualquer tecla para sair do sistema.");
//    Console.ReadKey();

//    usuarioLogado.Deslogar();

//    Console.WriteLine("\nVocê foi deslogado com sucesso.");

//    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
//    Console.ReadKey();
//}

//--------------------------------------------------------------------------------------

//new UsuarioSistema().Logar("arthur", "espadinha");

//--------------------------------------------------------------------------------------


//lambda para listas e enumerable (LINQ)

var carros = new List<Carro>()
{
    new Carro("Hyundai", "HB20-1", "Prata", 2014),
    new Carro("Hyundai", "HB20-2", "vermelho", 2022),
    new Carro("Hyundai", "HB20-3", "Preto", 2036),
    new Carro("Hyundai", "HB20-4", "Preto", 1998),
    new Carro("Hyundai", "HB20-5", "Branco", 2008),
    new Carro("Hyundai", "HB20-6", "Prata", 2014),
    new Carro("Hyundai", "HB20-7", "Prata", 2011),
    new Carro("Hyundai", "HB20-8", "Prata", 2017),
    new Carro("Hyundai", "HB20-9", "Prata", 2013)
};

carros[0].Lambidavel(carros);


//var selecionados = carros.Where(carro => carro.Cor != "Prata").OrderBy(carro => carro.Ano).ToList();

//foreach (var carro in selecionados)
//{
//    Console.WriteLine($"{carro.Modelo} - {carro.Ano}");
//}

Console.ReadKey();