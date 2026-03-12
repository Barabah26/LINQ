
namespace LINQ;

public class Exercise39
{
    public static string FindShortestWord(List<string> words)
    {
        return words.OrderBy(word => word.Length).First();
    }
}
