//Screen Sound Application
string mensagemBoasVindas = "Boas Vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>() { "U2", "Nine Inch Nails", "Red Hot Chilli Peppers" };
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine("\n\t " + mensagemBoasVindas+"\n");

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

    switch(opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("\t Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("\t Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("\t Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("\t Opção Inválida. \n \t Encerrando a aplicação ");
            break;
    }
}

            
void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("*******************************************************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("*******************************************************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesMenu();
};

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*******************************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("*******************************************************\n");
    for(int i = 0; i< listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i].ToString()}" );
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu Principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}


ExibirOpcoesMenu();