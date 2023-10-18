namespace CodeWarts.Infrastructure.Extensions;

public class HashSetSum
{
    public static int CalculateFor(HashSet<int> numbers)
    {
        var result = 0;
        for (int i = 0; i <= numbers.Count(); i++)
        {
            result += numbers.ElementAt(i);
        }
        return result;
    }
    
    public static int CalculateForEach(HashSet<int> numbers)
    {
        var result = 0;
        foreach (var number in numbers)
        {
            result += number;
        }
        return result;
    }
    
    public static int CalculateLinq(HashSet<int> numbers)
    {
        return numbers.Sum();
    }
}