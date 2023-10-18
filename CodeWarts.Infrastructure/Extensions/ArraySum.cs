namespace CodeWarts.Infrastructure.Extensions;

public class ArraySum
{
    public static long CalculateFor(int[] numbers)
    {
        var result = 0;
        for (int i = 0; i <= numbers.Length; i++)
        {
            result += numbers[i];
        }
        return result;
    }
    
    public static int CalculateForEach(int[] numbers)
    {
        var result = 0;
        foreach (var number in numbers)
        {
            result += number;
        }
        return result;
    }
    
    public static int CalculateLinq(int[] numbers)
    {
        return numbers.Sum();
    }
}