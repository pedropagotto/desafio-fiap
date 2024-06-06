using System.Text.Json.Serialization;

namespace Desafiofiap;

public class PayloadRequest
{
    public PayloadRequest(string key, string grupo)
    {
        Key = key;
        this.grupo = grupo;
    }
    [JsonPropertyName("Key")]
    public string Key { get; set; }
    
    [JsonPropertyName("grupo")]
    public string grupo { get; set; }
    
}
