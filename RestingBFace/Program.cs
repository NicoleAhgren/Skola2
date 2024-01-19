using RestSharp;
using System.Text.Json;

RestClient client = new("https://digi-api.com/api/v1/");

string digimonName = "Fla Wizarmon";
RestRequest request = new($"digimon/{digimonName}");

RestResponse response = client.GetAsync(request).Result;

Console.WriteLine(response.Content);
File.WriteAllText("Digimon.Json", response.Content);


Console.ReadLine();

//Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);

//Console.WriteLine(d.species.Name);
