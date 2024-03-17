class Podcast
{
    private List<Episode> episodes = new();
    public Podcast(string host, string name) 
    {
        Host = host;
        Name = name;
    }

    public string Host { get; }
    public string Name { get; }
    public int TotalEpisodes => episodes.Count;

    public void AddEpisodes (Episode episode)
    {
        episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Podcast {Name} hosted by {Host}  \n");

        foreach (Episode episode in episodes.OrderBy(e => e.Order))
        {
            Console.WriteLine(episode.Summary);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodes} episódios.");
    }
}