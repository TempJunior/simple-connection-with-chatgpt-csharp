namespace oop_2.domain.model;

public class Languages
{
    public string Name { get; set; }
    public string Framework {get; set;}

    public Languages(string name, string framework)
    {
        Name = name;
        Framework = framework;
    }
}