namespace CodeWarts.Infrastructure.Implementations.MaxGap;

public static class MaxGap
{
    public static int Result(int[] numbers)
    {
        Array.Sort(numbers);
        var maxDiff = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            var diff = Math.Abs(numbers[i] - numbers[i + 1]);
            if (maxDiff < diff)
                maxDiff = diff;
        }

        return maxDiff;
    }
}