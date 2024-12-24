using AluraPOO.Models;

namespace AluraPOO.Menus
{
    internal class MenuCloseApplication : Menu
    {
        public override void Execute(Dictionary<string, Banda> bandasRegistradas)
        {
            Environment.Exit(0);
        }
    }
}
