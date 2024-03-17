class Episode
{
    private List<string> guests = new();
    public Episode(string title, int order, int time)
    {
        Title = title;
        Order = order;
        Time = time;
    }

    public string Title { get; }
    public int Order { get; }
    public int Time { get; }
    public string Summary => $"{Order}. {Title}, ({Time} min) - {string.Join(", ", guests)}";

    public void AddGuests (string guest)
    {
        guests.Add(guest);
    }

}
