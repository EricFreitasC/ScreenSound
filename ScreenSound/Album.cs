class Album
{
    private List<Song> songs = new List<Song>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int FullTime => songs.Sum(s => s.Time);

    public void AddSong(Song song) 
    { 
        songs.Add(song);
    }

    public void ShowAlbumSongs()
    {
        Console.WriteLine($"Lista de músicas do album {Name}:\n");
        foreach (var song in songs) 
        { 
            Console.WriteLine($"Musica: {song.Name}");
        }
        Console.WriteLine($"Para ouvir esse album inteiro precisa de {FullTime} segundos");
    }
}