Banda queen = new Banda();
queen.Title = "Queen";

Album albumTheQueen = new Album();
albumTheQueen.Title = "A Night at The Opera";

Music music1 = new Music(queen);
music1.Title = "Love of my Life";
music1.Duration = 213;

Music music2 = new Music(queen);
music2.Title = "Bohemian Rhapsody";
music2.Duration = 354;

albumTheQueen.AddMusic(music1);
albumTheQueen.AddMusic(music2);

albumTheQueen.ShowAlbumInformation();

queen.AddAlbum(albumTheQueen);
queen.ShowDiscography();