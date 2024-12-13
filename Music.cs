class Music
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool Available { get; set; } // get e set são metodos de leitura(set) e escrita(get)
    public string ShortDescription
    {
        get
        {
            return $"A musica {Title} pertence a banda {Artist}";
        }
    }
    public string DurationDescription => $"A musica {Title} possui tempo de duração de {Duration} segundos";
    

    public void ShowMusicInformation()
    {
        Console.WriteLine($"Nome: {Title}");
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Duração: {Duration}");
        if (Available)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}

