using System.Runtime.InteropServices;

namespace CodeWarts.Infrastructure.Extensions;

public class SpanSum
{
    public static int CalculateFor(List<int> numbers)
    {
        var result = 0;
        for (int i = 0; i <= CollectionsMarshal.AsSpan(numbers).Length; i++)
        {
            result += numbers[i];
        }

        return result;
    }

    public static int CalculateForEach(List<int> numbers)
    {
        var result = 0;
        var span = CollectionsMarshal.AsSpan(numbers);
        foreach (var number in span)
        {
            result += number;
        }

        return result;
    }

    public static int CalculateLinq(List<int> numbers)
    {
        return CollectionsMarshal.AsSpan(numbers).ToArray().Sum();
    }
}