using System.Text.Json;
using oop_2.domain.filters;
using oop_2.domain.model;
using oop_2.domain.services;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!; 
        // LinqFilter.FilterAllMusicGenders(musics);
        // LinqOrder.ArtistListOrder(musics);
        // LinqFilter.FilterArtistByMusicGender(musics, "pop");
        // LinqFilter.FilterAllMusicByArtist(musics, "Eminem");

        var nameOfPeaple = new FavoriteSongs("Junior");
        var myFavoriteSongs = new FavoriteSongService(nameOfPeaple);
        myFavoriteSongs.AddFavoriteSong(musics[4]);
        myFavoriteSongs.AddFavoriteSong(musics[8]);
        myFavoriteSongs.AddFavoriteSong(musics[1478]);
        myFavoriteSongs.AddFavoriteSong(musics[336]);
        myFavoriteSongs.AddFavoriteSong(musics[777]);
        myFavoriteSongs.AddFavoriteSong(musics[6]);
        myFavoriteSongs.ShowAllFavoriteSongs();
        
        myFavoriteSongs.GenereteJsonFile();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error on request: {e.Message}");
        throw;
    }
}