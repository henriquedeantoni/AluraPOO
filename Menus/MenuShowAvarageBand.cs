using AluraPOO.Models;

namespace AluraPOO.Menus;

internal class MenuShowAvarageBand : Menu
{
    public override void Execute(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Execute(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir Média");
        Console.Write("Digite o nome da banda que deseja obter a média: ");
        string nomeDaBanda = Console.ReadLine()!;
        int soma = 0;
        int notas = 0;
        double media = 0;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"A banda {nomeDaBanda} possui uma nota média de {banda.Avarage}");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi cadastrada.");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
