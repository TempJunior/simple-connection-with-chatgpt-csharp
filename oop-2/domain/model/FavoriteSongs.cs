namespace oop_2.domain.model;

public class FavoriteSongs
{
    public string? Name { get; set; }
    public List<Music> FavoriteSongList { get; }

    public FavoriteSongs(string name)
    {
        this.Name = name;
        this.FavoriteSongList = new List<Music>();
    }
    
    public FavoriteSongs(){}
}