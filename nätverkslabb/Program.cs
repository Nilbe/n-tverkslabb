using RestSharp;
using System.Text.Json;

// RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
// RestRequest request = new RestRequest("pokemon/ditto");

// RestResponse response = pokeClient.GetAsync(request).Result;
// pokemon p = JsonSerializer.Deserialize<pokemon>(response.Content);

// Console.WriteLine(p.Name);
// Console.WriteLine(p.Weight);

// Console.ReadLine();

RestClient starwarsClient = new RestClient("https://swapi.py4e.com/api/");
RestRequest request = new RestRequest("people/1/");

RestResponse response = starwarsClient.GetAsync(request).Result;
character c = JsonSerializer.Deserialize<character>(response.Content);

Console.WriteLine(c.name);
Console.WriteLine(c.height);
Console.WriteLine(c.mass);

Console.ReadLine();