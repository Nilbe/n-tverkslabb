using System.Text.Json.Serialization;

// public class pokemon
// {
//     [JsonPropertyName("name")]
//     public string Name { get; set; }

//     [JsonPropertyName("weight")]
//     public int Weight { get; set; }
    
//     [JsonPropertyName("is_default")]
//     public bool IsDefault { get; set; }
// }

public class character
{ 
    public string name { get; set; }

    public string height { get; set; }

    public string mass { get; set; }
}