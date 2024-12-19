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

Episode ep1 = new(3250, 2, "Programação Orientada à objetos");
ep1.AddGuest("João Almeida");
ep1.AddGuest("Francisco Beltrão");
Console.WriteLine(ep1.Summary);

Episode ep2 = new(4680, 1, "Algoritmos");
ep2.AddGuest("João Almeida");
ep2.AddGuest("Francisco Beltrão");
ep2.AddGuest("Flavia Gonçalves");
Console.WriteLine(ep2.Summary);

Podcast podcast = new("Jonas Klink", "Programador Avião");
podcast.AddEpisodes(ep1);
podcast.AddEpisodes(ep2);
podcast.ShowDetails();