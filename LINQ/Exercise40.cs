
namespace LINQ;

public class Exercise40
{
    public static IEnumerable<DateTime> GetFridaysOfYear(int year, IEnumerable<DateTime> dates)
    {
        return dates.Where(date => date.Year == year && date.DayOfWeek == DayOfWeek.Friday).Distinct();
    }
}
