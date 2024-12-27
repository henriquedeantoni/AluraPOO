namespace AluraPOO.Models;

internal interface IAvailable
{
    void AddRating(Rating rating);
    double Average { get; }
}
