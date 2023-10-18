namespace CodeWarts.Infrastructure.Practice;

public static class TheFastestSum
{
    public static int[] GetNumbers()
    {
        var random = new Random();
        return Enumerable.Range(1, 1000000).Select(x => random.Next(1, 100)).ToArray();
    }

    public static int SumLinq(int[] numbers) => numbers.Sum();

    public static int SumForEach(int[] numbers)
    {
        var result = 0;
        foreach (var item in numbers)
        {
            result += item;
        }

        return result;
    }

    public static int SumFor(int[] numbers)
    {
        var result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }

        return result;
    }

    public static int SumFor4(int[] numbers)
    {
        var result1 = 0;
        var result2 = 0;
        var result3 = 0;
        var result4 = 0;
        for (int i = 0; i < numbers.Length / 4; i += 4)
        {
            result1 += numbers[i];
            result2 += numbers[i + 1];
            result3 += numbers[i + 2];
            result4 += numbers[i + 3];
        }

        return (result1 + result2 + result3 + result4);
    }
    
    public static int SumFor4Span(int[] numbers)
    {
        var result1 = 0;
        var result2 = 0;
        var result3 = 0;
        var result4 = 0;
        var numbersSpan = numbers.AsSpan();
        for (int i = 0; i < numbers.Length / 4; i += 4)
        {
            result1 += numbersSpan[i];
            result2 += numbersSpan[i + 1];
            result3 += numbersSpan[i + 2];
            result4 += numbersSpan[i + 3];
        }

        return (result1 + result2 + result3 + result4);
    }

    public static int SumSpanFor(int[] numbers)
    {
        ReadOnlySpan<int> numSpan = numbers;
        var result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numSpan[i];
        }

        return result;
    }
    
    public static int SumSpanForEach(int[] numbers)
    {
        var result = 0;
        foreach (var item in numbers.AsSpan())
        {
            result += item;
        }

        return result;
    }

    public static int SumForEachParallel(int[] numbers)
    {
        var result = 0;
        Parallel.ForEach(numbers, num => { result += num; });
        return result;
    }

    public static int SumForParallel(int[] numbers)
    {
        var result = 0;
        Parallel.For(0, numbers.Length - 1, x => { result += numbers[x]; }
        );
        return result;
    }
}