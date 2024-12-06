string mensagemBoasVindas = "Boas Vindas ao Screen Sound";

void ExibirMensagemBoasVindas()
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
            Console.WriteLine("\t Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2:
            Console.WriteLine("\t Voce escolheu a opção " + opcaoEscolhidaNumerica);
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


ExibirMensagemBoasVindas();
ExibirOpcoesMenu();