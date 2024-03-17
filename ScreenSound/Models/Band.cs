namespace ScreenSound.Models;

internal class Band
{
    private List<Album> albums = new List<Album>();
    private List<Assessment> scores = new List<Assessment>();
   
    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Media
    {
        get
        {
            if (scores.Count == 0) return 0;
            else return scores.Average(a => a.Score);
        }
    }
    public List<Album> Albums => albums;
    public void AddNewAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddNewScore(Assessment score)
    {
        scores.Add(score);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.FullTime})");
        }
    }
}