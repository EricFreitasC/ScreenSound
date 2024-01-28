class Song
{
    public Song(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    public Band Artist { get; }
    public int Time { get; set; }
    public bool Available {  get; set; }
    public Genre Genre { get; set; }
    public string BriefDescription => 
        $"A musica {Name} pertence à banda {Artist}";



    public void ShowTechnicalSheet()
    {
        Console.WriteLine($"\nNome: {Name}");
        Console.WriteLine($"Artista: {Artist.Name}");
        Console.WriteLine($"Duração: {Time}");
        Console.WriteLine(BriefDescription);
        if (Available)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Prime");
        }
    }
    
}
