using AluraPOO.Menus;
using AluraPOO.Models;

Banda ira = new Banda("Ira!");
ira.AddRating(new Rating(10));
ira.AddRating(new Rating(9));
ira.AddRating(new Rating(7));
Banda beatles = new("The Beatles");


//Screen Sound Application
string mensagemBoasVindas = "Boas Vindas ao Screen Sound";
Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Title, ira);
bandasRegistradas.Add(beatles.Title, beatles);
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\n\t " + mensagemBoasVindas + "\n");
}
void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\t Digite 1 para registrar banda.");
    Console.WriteLine("\t Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("\t Digite 3 para avaliar uma banda.");
    Console.WriteLine("\t Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("\t Digite -1 para sair. \n");
    Console.Write("\t Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            MenuRegisterBand menuRegisterBand = new MenuRegisterBand();
            menuRegisterBand.Execute(bandasRegistradas);
            ExibirOpcoesMenu();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            MenuRateBand menuRateBand = new MenuRateBand();
            menuRateBand.Execute(bandasRegistradas);
            ExibirOpcoesMenu();
            break;
        case 4:
            MenuShowAvarageBand menuShowAvarageBand = new MenuShowAvarageBand();
            menuShowAvarageBand.Execute(bandasRegistradas);
            ExibirOpcoesMenu();
            break;
        case 5:
            MenuShowDetails menuShowDetails = new MenuShowDetails();
            menuShowDetails.Execute(bandasRegistradas);
            ExibirOpcoesMenu();
            break;
        case -1:
            SairAplicação();
            break;
        default:
            Console.WriteLine("\t Opção Inválida. \n \t Encerrando a aplicação ");
            break;
    }
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeCaracteres = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void SairAplicação()
{
    Environment.Exit(0);
}
ExibirOpcoesMenu();

