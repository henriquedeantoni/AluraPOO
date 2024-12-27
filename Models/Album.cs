namespace AluraPOO.Models;

internal class Album : IAvailable
{
    public Album(string title)
    {
        Title = title;
    }

    private List<Music> musics = new List<Music>();
    private List<Rating> rates = new();
    public string Title { get; }
    public int TotalDuration => musics.Sum(music => music.Duration);

    public double Average
    {
        get
        {
            if (rates.Count == 0) return 0;
            else return rates.Average(a => a.BandRating);
        }
    }

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

    public void AddRating(Rating rating)
    {
        rates.Add(rating);
    }
}