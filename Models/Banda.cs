namespace AluraPOO.Models;

internal class Banda
{
    public Banda(string title)
    {
        Title = title;
    }

    private List<Album> albums = new List<Album>();
    private List<int> ratings = new List<int>();
    public string Title { get; }
    public double Avarage => ratings.Average();

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddRating(int rating)
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