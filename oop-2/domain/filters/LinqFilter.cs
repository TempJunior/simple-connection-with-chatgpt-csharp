using oop_2.domain.model;

namespace oop_2.domain.filters;

public class LinqFilter
{
    public static void FilterAllMusicGenders(List<Music> list)
    {
        var allMusicGenders = list.Select(g => g.Genre)
            .Distinct()
            .ToList();

        foreach (var g in allMusicGenders)
        {
            Console.WriteLine($"Genre >> {g}");
        }
    }

    public static void FilterArtistByMusicGender(List<Music> list, string genre)
    {
        var artistByMusicGender = list.Where(g => g.Genre.Contains(genre))
            .Select(g => g.Artist)
            .Distinct()
            .ToList();

        Console.WriteLine($"All Artists by Gender {genre}: ");
        foreach (var a in artistByMusicGender)
        {
            Console.WriteLine($"Artist: {a}");
        }
    }

    public static void FilterAllMusicByArtist(List<Music> list, string artist)
    {
        var  allMusicByArtist = list.Where(m => m.Artist!.Equals(artist))
            .Select(m => m.Name)
            .ToList();

        Console.WriteLine($"All Musics of Artist {artist}: ");
        foreach (var m in allMusicByArtist)
        {
            Console.WriteLine($"Music: {m}");
        }
    }
    
}