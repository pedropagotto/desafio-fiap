using System.Text;
using System.Text.Json;
using Desafiofiap;


var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Post, "https://fiap-inaugural.azurewebsites.net/fiap");
var count = 0;
while (true)
{
    try
    {
        if (count == 5)
            break;
        
        var payload = new PayloadRequest(StringExtensions.GeneratorKey(), "sala_11");
        Console.WriteLine($"{count} - {payload.Key}");
        var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
        request.Content = content;
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        if (!response.Content.ReadAsStringAsync().Result.Contains("Tente novamente grupo:"))
        {
            break;
        }
        
    }
    catch (Exception ex)
    {
        Console.Write(ex.Message);
    }

    count =+ 1;
}
