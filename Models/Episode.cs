namespace AluraPOO.Models;

internal class Episode
{
    #region Constructor
    public Episode(int duration, int index, string title)
    {
        Duration = duration;
        Index = index;
        Title = title;
    }

    #endregion

    #region Props
    private List<string> guests = new();

    public int Duration { get; }
    public int Index { get; }
    public string Title { get; }
    public string Summary => $"{Index}. {Title} ({Duration} segundos) - \n Convidados:\n {string.Join(", ", guests)}";

    #endregion

    #region Methods
    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }
    #endregion

    

}