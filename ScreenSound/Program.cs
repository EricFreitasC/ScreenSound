Album albumTravisScott = new Album();
albumTravisScott.Name = "Utopia";

Song song1 = new Song();
song1.Name = "Hyaena";
song1.Time = 212;

Song song2 = new Song();
song2.Name = "Thank God";
song2.Time = 184;

albumTravisScott.AddSong(song1);
albumTravisScott.AddSong(song2);

Band travisScott = new Band();
travisScott.Name = "Travis Scott";
travisScott.AddNewAlbum(albumTravisScott);
travisScott.ShowDiscography();

albumTravisScott.ShowAlbumSongs();