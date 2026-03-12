
namespace LINQ;

public class Exercise37
{
    public static bool IsAnyWordWhiteSpace(List<string> words)
    {
        return words != null && words.Any(word => !string.IsNullOrEmpty(word) && word.All(char.IsWhiteSpace));
    }
}
