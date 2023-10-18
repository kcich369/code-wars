namespace CodeWarts.Infrastructure.Extensions;

public class ListSum
{
    public static int CalculateFor(List<int> numbers)
    {
        var result = 0;
        for (int i = 0; i <= numbers.Count; i++)
        {
            result += numbers[i];
        }
        return result;
    }
    
    public static int CalculateForEach(List<int> numbers)
    {
        var result = 0;
        foreach (var number in numbers)
        {
            result += number;
        }
        return result;
    }
    
    public static int CalculateLinq(List<int> numbers)
    {
        return numbers.Sum();
    }
}