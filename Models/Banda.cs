namespace AluraPOO.Models;

internal class Banda : IAvailable
{
    public Banda(string title)
    {
        Title = title;
    }

    private List<Album> albums = new List<Album>();
    private List<Rating> ratings = new List<Rating>();
    public string Title { get; }
    public double Average
    {
        get
        {
            if(ratings.Count == 0) return 0;
            else return ratings.Average(r => r.BandRating);
        }
    }
    public List<Album> Albums => albums;

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddRating(Rating rating)
    {
        ratings.Add(rating);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discografia da banda {Title} é: \n ");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Álbum {album.Title} ({album.TotalDuration})");
        }
        
    }
}