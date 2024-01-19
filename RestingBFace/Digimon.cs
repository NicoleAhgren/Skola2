using System.Text.Json.Serialization;
public class Digimon
{
    [JsonPropertyName("name")]
    public string Name {get; set;}
    [JsonPropertyName("id")]
    public int Id {get; set;}
    [JsonPropertyName("weight")]
    public int Weight {get; set;}
    [JsonPropertyName("species")]
    public DigimonSpecies species {get; set;}
}
