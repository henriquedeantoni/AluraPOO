namespace AluraPOO.Models;

internal class Rating
{
    public Rating(int bandRating)
    {
        if(bandRating<0) bandRating = 0;
        if(bandRating>10) bandRating = 10;

        BandRating = bandRating;
    }

    public int BandRating { get; }

    //static method
    public static Rating Parse(string text)
    {
        int rating = int.Parse(text);
        return new Rating(rating);
    }
}
