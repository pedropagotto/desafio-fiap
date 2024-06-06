namespace Desafiofiap;

public static class StringExtensions
{
    private static char[] Alfabeto()=> [
        'A', 'Á', 'Â', 'Ã', 'À', 'B', 'C', 'D', 'E', 'É', 'Ê', 'È', 'F', 'G', 'H', 'I', 'Í', 'Î', 'Ì',
        'J', 'K', 'L', 'M', 'N', 'O', 'Ó', 'Ô', 'Õ', 'Ò', 'P', 'Q', 'R', 'S', 'T', 'U', 'Ú', 'Û', 'Ù',
        'V', 'W', 'X', 'Y', 'Ý', 'Z', 'a', 'á', 'â', 'ã', 'à', 'b', 'c', 'd', 'e', 'é', 'ê', 'è', 'f',
        'g', 'h', 'i', 'í', 'î', 'ì', 'j', 'k', 'l', 'm', 'n', 'o', 'ó', 'ô', 'õ', 'ò', 'p', 'q', 'r',
        's', 't', 'u', 'ú', 'û', 'ù', 'v', 'w', 'x', 'y', 'ý', 'z'
    ];

    private static char GeneratorCaracter()
    {
        var alfabeto = StringExtensions.Alfabeto();
        var index = new Random().Next(0,alfabeto.Length -1);
        return alfabeto[index];
    }
    
    private static int GeneratorCode()
    {
        return new Random().Next(0,9);
    }

    public static string GeneratorKey()
    {
        return $"{GeneratorCaracter()}{GeneratorCode()}{GeneratorCode()}{GeneratorCaracter()}";
    }
    
    
    
}
