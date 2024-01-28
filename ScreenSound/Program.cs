Band travisScott = new Band("Travis Scott");

Album albumTravisScott = new Album("Utopia");

Song song1 = new Song(travisScott, "Hyaena")
{
    Time = 212,
    Available = true,
};


Song song2 = new Song(travisScott, "Thank God")
{
    Time = 184,
    Available = false,
};

albumTravisScott.AddSong(song1);
albumTravisScott.AddSong(song2);
travisScott.AddNewAlbum(albumTravisScott);

song1.ShowTechnicalSheet();
song2.ShowTechnicalSheet();
albumTravisScott.ShowAlbumSongs();
travisScott.ShowDiscography();