class Banda
{
    public Banda(string title)
    {
        Title = title;
    }

    private List<Album> albums = new List<Album>();
    public string Title { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
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