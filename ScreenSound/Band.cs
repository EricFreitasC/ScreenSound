class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; set; }

    public void AddNewAlbum(Album album)
    {
        albums.Add(album);
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