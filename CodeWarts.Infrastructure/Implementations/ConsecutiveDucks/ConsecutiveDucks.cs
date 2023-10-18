using System.Diagnostics;

namespace CodeWarts.Infrastructure.Implementations.ConsecutiveDucks;

public static class ConsecutiveDucks
{
    public static bool Execute(int n)
    {
        var numbers = Enumerable.Range(1, n / 2 + 2).Reverse().ToList();
        return true;
    }

    private static bool ExecuteSeq(int n)
    {
        var numbers = Enumerable.Range(1, n / 2 + 2).Reverse().ToList();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (CheckCursor(n, i, numbers.Skip(i).ToList())) ;
            return true;
        }

        return false;
    }

    private static bool CheckCursor(int mainValue, int index, IList<int> numbers)
    {
        if (numbers.First() <= mainValue / 4)
            return false;
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
            if (sum == mainValue)
                return true;
            if (sum > mainValue)
                return false;
        }

        return false;
    }

    private static bool ExecuteParalell(int n)
    {
        var numbers = Enumerable.Range(1, n / 2 + 2).Reverse().ToArray();
        numbers.TryGetNonEnumeratedCount(out int count);
        var r = false;
        Parallel.For(0, count, (i) =>
        {
            if (!CheckCursorParalell(n, i, numbers.Skip(i).ToList())) return;
            r = true;
            return;
        });

        return r;
    }

    private static bool CheckCursorParalell(int mainValue, int index, IList<int> numbers)
    {
        var sum = 0;
        var r = false;
        Parallel.ForEach(numbers, x =>
        {
            sum += x;
            if (sum == mainValue)
            {
                r = true;
                return;
            }

            if (sum > mainValue)
                return;
        });
        return r;
    }
}