Banda queen = new Banda("Queen");

Album albumTheQueen = new Album("A Night at The Opera");

Music music1 = new Music(queen, "Love of my Life")
{
    Duration = 213,
    Available = true,
};

Music music2 = new Music(queen, "Who Wants to Live Forever")
{
    Duration = 305,
    Available = false,
};



Music music3 = new Music(queen, "Bohemian Rhapsody");
music3.Duration = 354;

albumTheQueen.AddMusic(music1);
albumTheQueen.AddMusic(music2);
albumTheQueen.AddMusic(music3);

albumTheQueen.ShowAlbumInformation();

music1.ShowMusicInformation();
music2.ShowMusicInformation();

queen.AddAlbum(albumTheQueen);
queen.ShowDiscography();