using System.Text;
using System.Text.Json;

namespace Desafiofiap;

public static class StringExtensions
{
    private static char[] Alphabet()=> [
        'A', 'Á', 'Â', 'Ã', 'À', 'B', 'C', 'D', 'E', 'É', 'Ê', 'È', 'F', 'G', 'H', 'I', 'Í', 'Î', 'Ì',
        'J', 'K', 'L', 'M', 'N', 'O', 'Ó', 'Ô', 'Õ', 'Ò', 'P', 'Q', 'R', 'S', 'T', 'U', 'Ú', 'Û', 'Ù',
        'V', 'W', 'X', 'Y', 'Ý', 'Z', 'a', 'á', 'â', 'ã', 'à', 'b', 'c', 'd', 'e', 'é', 'ê', 'è', 'f',
        'g', 'h', 'i', 'í', 'î', 'ì', 'j', 'k', 'l', 'm', 'n', 'o', 'ó', 'ô', 'õ', 'ò', 'p', 'q', 'r',
        's', 't', 'u', 'ú', 'û', 'ù', 'v', 'w', 'x', 'y', 'ý', 'z', '0', '0','1', '2', '3', '4', '5', 
        '6', '7', '8', '9'
    ];

    private static char[] Numbers() =>
    [
        '0', '0', '1', '2', '3', '4', '5',
        '6', '7', '8', '9'
    ];
    

    private static char GeneratorCaracter()
    {
        var alfabeto = Alphabet();
        var index = new Random().Next(0, alfabeto.Length -1);
        return alfabeto[index];
    }
    
    public static string GeneratorKey()
    {
        var codeArray =  $"{GeneratorCaracter()}{GeneratorCaracter()}{GeneratorCaracter()}{GeneratorCaracter()}{GeneratorCaracter()}".ToCharArray();

        if (Numbers().Any(n => codeArray.Contains(n)))
            return new string(codeArray);

        var index = new Random().Next(0, 4);
        var indexNumber = new Random().Next(0, 9);
        codeArray[index] = Numbers()[indexNumber];

        return new string(codeArray);
    }

    public static StringContent BuildPayload(PayloadRequest request)
    {
        return new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
    }
}
