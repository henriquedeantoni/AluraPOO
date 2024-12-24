using AluraPOO.Models;

namespace AluraPOO.Menus
{
    internal class MenuShowRegisteredBand : Menu
    {

        public override void Execute(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Execute(bandasRegistradas);
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
