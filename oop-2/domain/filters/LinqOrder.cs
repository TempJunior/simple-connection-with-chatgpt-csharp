using oop_2.domain.model;

namespace oop_2.domain.filters;

public class LinqOrder
{
    public static void ArtistListOrder(List<Music> list)
    {
        var orderArtist = list.OrderBy(a => a.Artist)
            .Select(a => a.Artist)
            .Distinct()
            .ToList();

        Console.WriteLine($"Order Artist List");
        foreach (var item in orderArtist)
        {
            Console.WriteLine("Artist: " + item);
        }
    }
}