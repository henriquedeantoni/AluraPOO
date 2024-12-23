namespace AluraPOO.Models;

internal class Podcast
{
    #region Constructor

    public Podcast(string host, string title)
    {
        Host = host;
        Title = title;
    }

    #endregion


    #region Props

    public string Host { get; }
    public string Title { get;}
    public int TotalEpisodes => EpisodeList.Count;
    private List<Episode> EpisodeList = new List<Episode>();
    #endregion

    #region Methods
    public void AddEpisodes(Episode episode)
    {
        EpisodeList.Add(episode);
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Este é o Podcast {Title} e oferecido por {Host}");
        Console.WriteLine($"\nPossui um total de {TotalEpisodes} Episódios.\nA lista de episódios pode ser vista aqui:\n");
        foreach (Episode episode in EpisodeList.OrderBy(e=>e.Index))
        {
            Console.WriteLine(episode.Summary);
        }
    }
    #endregion


}