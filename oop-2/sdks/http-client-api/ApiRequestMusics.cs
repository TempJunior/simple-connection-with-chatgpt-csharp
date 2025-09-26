using System.Text.Json;
using oop_2.domain.filters;
using oop_2.domain.model;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!; 
        // LinqFilter.FilterAllMusicGenders(musics);
        LinqOrder.ArtistListOrder(musics);
        // LinqFilter.FilterArtistByMusicGender(musics, "pop");
        LinqFilter.FilterAllMusicByArtist(musics, "Eminem");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error on request: {e.Message}");
        throw;
    }
}