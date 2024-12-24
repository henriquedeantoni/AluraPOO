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
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            MenuRateBand menuRateBand = new MenuRateBand();
            menuRateBand.Execute(bandasRegistradas);
            break;
        case 4:
            ExibeMediaBanda();
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

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.Write("Agora digite o título do álbum: ");
    string tituloAlbum = Console.ReadLine()!;
    /**
     * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
     */
    Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesMenu();
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
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
void ExibeMediaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir Média");
    Console.Write("Digite o nome da banda que deseja obter a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    int soma = 0;
    int notas = 0;
    double media = 0;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        /*
        foreach(int banda in bandasRegistradas[nomeDaBanda])
        {
            notas ++;
            soma += banda;
        }
        media = soma / notas;
        Console.WriteLine($"A banda {nomeDaBanda} possui uma nota média de {media}");
        */
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A banda {nomeDaBanda} possui uma nota média de {banda.Avarage}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi cadastrada.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void SairAplicação()
{
    Environment.Exit(0);
}
ExibirOpcoesMenu();

