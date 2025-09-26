using System.Text.Json;
using oop_2.domain.model;

namespace oop_2.domain.services;

public class FavoriteSongService
{
    protected FavoriteSongs favoriteSongs = new FavoriteSongs();

    public FavoriteSongService(FavoriteSongs favoriteSongs)
    {
        this.favoriteSongs = favoriteSongs;
    }

    public void AddFavoriteSong(Music song)
    {
        favoriteSongs.FavoriteSongList.Add(song);
    }

    public void ShowAllFavoriteSongs()
    {
        Console.WriteLine($"This is a favorite songs of {favoriteSongs.Name}");

        foreach (var m in favoriteSongs.FavoriteSongList)
        {
            Console.WriteLine($"Music name - {m.Name} of artist - {m.Artist}");
        }
    }

    public void GenereteJsonFile()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = favoriteSongs.Name,
            musics = favoriteSongs.FavoriteSongList
        });

        string nameOfFile = $"favorite-songs{favoriteSongs.Name}.json";
        File.WriteAllText(nameOfFile, json);
        Console.WriteLine($"Json file created {Path.GetFullPath(nameOfFile)}");
    }
}