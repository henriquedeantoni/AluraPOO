Music musica1 = new Music();
musica1.Title = "Roxane";
musica1.Artist = "The Police";
musica1.Duration = 273;
musica1.Available = true;
Console.WriteLine(musica1.ShortDescription);
Console.WriteLine(musica1.DurationDescription);

Music musica2 = new Music();
musica2.Title = "Vertigo";
musica2.Artist = "U2";
musica2.Duration = 367;
musica2.Available = true;
Console.WriteLine(musica2.ShortDescription);
Console.WriteLine(musica2.DurationDescription);

musica1.ShowMusicInformation();
musica2.ShowMusicInformation();