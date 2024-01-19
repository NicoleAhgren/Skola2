using System.Text.Json.Serialization;

public class DigimonSpecies
{
    [JsonPropertyName("name")]
    public string Name {get; set;}
}
