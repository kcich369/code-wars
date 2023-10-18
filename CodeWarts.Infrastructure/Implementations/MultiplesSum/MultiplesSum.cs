using System.Collections;

namespace CodeWarts.Infrastructure.Implementations.MultiplesSum;

public class MultiplesSum
{
    private static readonly int[] Numbers = new int[] { 3, 5 };

    public static int SolutionBest(int value)
    {
        var a = Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).ToList();
        return Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
    }

    public static int Solution(int value)
    {
        var multiples = new List<int>(0);
        foreach (var number in Numbers)
        {
            var val = 0;
            var num = 1;
            while (true)
            {
                val = num * number;
                if (val > value)
                    break;
                if (!multiples.Contains(val))
                    multiples.Add(val);
                num++;
            }
        }

        return multiples.Sum();
    }

    public static int SolutionArrayListOfType(int value)
    {
        var multiples = new ArrayList(0);
        foreach (var number in Numbers)
        {
            var val = 0;
            var num = 1;
            while (true)
            {
                val = num * number;
                if (val > value)
                    break;
                if (!multiples.Contains(val))
                    multiples.Add(val);
                num++;
            }
        }

        return multiples.OfType<int>().Sum();
    }

    public static int SolutionArrayListCast(int value)
    {
        var multiples = new ArrayList(0);
        foreach (var number in Numbers)
        {
            var val = 0;
            var num = 1;
            while (true)
            {
                val = num * number;
                if (val > value)
                    break;
                if (!multiples.Contains(val))
                    multiples.Add(val);
                num++;
            }
        }

        return multiples.Cast<int>().Sum();
    }

    public static int SolutionArray(int value)
    {
        int[] multiples = new int[550];
        var index = 0;
        foreach (var number in Numbers)
        {
            var val = 0;
            var num = 1;
            while (true)
            {
                val = num * number;
                if (val > value)
                    break;
                if (!multiples.Contains(val))
                {
                    multiples[index] = val;
                    index++;
                }

                num++;
            }
        }

        return multiples.Sum();
    }

    public static int SolutionDistinct(int value)
    {
        var multiples = new List<int>(0);
        foreach (var number in Numbers)
        {
            var result = 0;
            var num = 1;
            while (true)
            {
                result = num * number;
                if (result >= value)
                    break;
                multiples.Add(result);
                num++;
            }
        }

        return multiples.Distinct().Sum();
    }

    public static int SolutionArrayDistinct(int value)
    {
        int[] multiples = new int[550];
        var index = 0;
        foreach (var number in Numbers)
        {
            var result = 0;
            var num = 1;
            while (true)
            {
                result = num * number;
                if (result > value)
                    break;
                multiples[index] = result;
                num++;
                index++;
            }
        }

        return multiples.Distinct().Sum();
    }

    public static int SolutionDistinctArrayListOfType(int value)
    {
        var multiples = new ArrayList(0);
        foreach (var number in Numbers)
        {
            var result = 0;
            var num = 1;
            while (true)
            {
                result = num * number;
                if (result > value)
                    break;
                multiples.Add(result);
                num++;
            }
        }

        return multiples.OfType<int>().Distinct().Sum();
    }

    public static int SolutionDistinctArrayListCast(int value)
    {
        var multiples = new ArrayList(0);
        foreach (var number in Numbers)
        {
            var result = 0;
            var num = 1;
            while (true)
            {
                result = num * number;
                if (result > value)
                    break;
                multiples.Add(result);
                num++;
            }
        }

        return multiples.Cast<int>().Distinct().Sum();
    }
}