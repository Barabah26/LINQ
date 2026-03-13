namespace LINQ;

public class Exercise41
{
    public static double CalculateAverageDurationInMilliseconds(IEnumerable<TimeSpan> timeSpans)
    {
        return timeSpans.Select(t => t.Milliseconds).Average();
    }
}
