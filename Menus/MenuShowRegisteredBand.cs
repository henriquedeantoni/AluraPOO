using AluraPOO.Models;

namespace AluraPOO.Menus
{
    internal class MenuShowRegisteredBand : Menu
    {

        internal void Execute(Dictionary<string, Banda> bandasRegistradas)
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
        }
    }
}
