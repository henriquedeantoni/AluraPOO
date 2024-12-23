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
            AvaliarUmaBanda();
            break;
        case 4:
            ExibeMediaBanda();
            break;
        case -1:
            SairAplicação();
            break;
        default:
            Console.WriteLine("\t Opção Inválida. \n \t Encerrando a aplicação ");
            break;
    }
}
void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    // se a banda exitir no dicionario >> atribuir uma nota
    // senão, volta ao menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        Rating rating = Rating.Parse(Console.ReadLine()!);
        banda.AddRating(rating);
        Console.WriteLine($"\nA nota {rating.BandRating} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
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

//Parte Antiga
/*
Banda queen = new Banda("Queen");

Album albumTheQueen = new Album("A Night at The Opera");

Music music1 = new Music(queen, "Love of my Life")
{
    Duration = 213,
    Available = true,
};

Music music2 = new Music(queen, "Who Wants to Live Forever")
{
    Duration = 305,
    Available = false,
};



Music music3 = new Music(queen, "Bohemian Rhapsody");
music3.Duration = 354;

albumTheQueen.AddMusic(music1);
albumTheQueen.AddMusic(music2);
albumTheQueen.AddMusic(music3);

albumTheQueen.ShowAlbumInformation();

music1.ShowMusicInformation();
music2.ShowMusicInformation();

queen.AddAlbum(albumTheQueen);
queen.ShowDiscography();

Episode ep1 = new(3250, 2, "Programação Orientada à objetos");
ep1.AddGuest("João Almeida");
ep1.AddGuest("Francisco Beltrão");
Console.WriteLine(ep1.Summary);

Episode ep2 = new(4680, 1, "Algoritmos");
ep2.AddGuest("João Almeida");
ep2.AddGuest("Francisco Beltrão");
ep2.AddGuest("Flavia Gonçalves");
Console.WriteLine(ep2.Summary);

Podcast podcast = new("Jonas Klink", "Programador Avião");
podcast.AddEpisodes(ep1);
podcast.AddEpisodes(ep2);
podcast.ShowDetails();
*/