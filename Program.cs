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
        
        var payload = new PayloadRequest(StringExtensions.GeneratorKey(), "sala_11");
        
        request.Content = StringExtensions.BuildPayload(payload);
        Console.WriteLine($"{count} - {payload.Key} - {DateTime.Now.ToString("dd/MM/yy HH:mm:ss")}");
        var response = client.Send(request);
        response.EnsureSuccessStatusCode();
        count = count + 1;
        
        if (!response.Content.ReadAsStringAsync().Result.Contains("Tente novamente grupo:"))
        {
            return;
        }
        
    }
    catch (Exception ex)
    {
        Console.Write(ex.Message);
    }

    
}
