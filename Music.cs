public class Music
{
    public string title;
    public string artist;
    public int duration;
    public bool available;

    public void ShowMusicInformation()
    {
        Console.WriteLine($"Nome: {title}");
        Console.WriteLine($"Artista: {artist}");
        Console.WriteLine($"Duração: {duration}");
        if (available)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}

