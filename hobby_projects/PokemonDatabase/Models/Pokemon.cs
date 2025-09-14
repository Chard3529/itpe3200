namespace PokemonDatabase.Models;

public class Pokemon
{
    public int DexId { get; set; }
    public string Name { get; set; }

    public string Type { get; set; }

    public string? item { get; set; }

    public Pokemon(int dexId, string name, string type)
    {
        DexId = dexId;
        Name = name;
        Type = type;
    }

}

