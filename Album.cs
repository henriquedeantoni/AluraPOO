class Album
{
    public Album(string title)
    {
        Title = title;
    }

    private List<Music> musics = new List<Music>();
    public string Title { get; }
    public int TotalDuration => musics.Sum(music => music.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAlbumInformation()
    {
        Console.WriteLine($"Lista de músicas do álbum {Title}: \n");
        foreach(var music in musics)
        {
            Console.WriteLine($"Música: {music.Title}" );
        }
        Console.WriteLine($"\nA duração total do album é de {TotalDuration}");
    }
}