using System.Text.Json.Serialization;

namespace oop_2.domain.model;

public class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    public void musicDetails()
    {
        Console.WriteLine($"Music: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
    }
}