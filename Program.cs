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

Dictionary<int, Menu> options = new Dictionary<int, Menu>();
options.Add(1, new MenuRegisterBand());
options.Add(2, new MenuShowRegisteredBand());
options.Add(3, new MenuRateBand());
options.Add(4, new MenuShowAvarageBand());
options.Add(5, new MenuRateAlbum());
options.Add(6, new MenuShowDetails());
options.Add(-1, new MenuCloseApplication());

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
    Console.WriteLine("\t Digite 5 para Avaliar um album.");
    Console.WriteLine("\t Digite 6 para exibir detalhes de uma banda.");
    Console.WriteLine("\t Digite -1 para sair. \n");
    Console.Write("\t Digite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if(options.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuToShow = options[opcaoEscolhidaNumerica];
        menuToShow.Execute(bandasRegistradas);
        if(opcaoEscolhidaNumerica>0) ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine("Opção Invalida");
    }

}

ExibirOpcoesMenu();

