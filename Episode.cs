class Episode
{
    private List<string> guests = new();
    public Episode(int duration, int index, string title)
    {
        Duration = duration;
        Index = index;
        Title = title;
    }

    public int Duration { get; }
    public int Index { get; }
    public string Title { get; }
    public string Summary => $"{Index}. {Title} ({Duration} segundos) - {string.Join(", ", guests)}";

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }

}