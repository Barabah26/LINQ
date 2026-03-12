
namespace LINQ;

public class Exercise38
{
    public static int CountListsContainingZeroLongerThan(int length, List<List<int>> listsOfNumbers)
    {
        return listsOfNumbers.Count(n => n.Contains(0) && n.Count() > length);
    }
}
