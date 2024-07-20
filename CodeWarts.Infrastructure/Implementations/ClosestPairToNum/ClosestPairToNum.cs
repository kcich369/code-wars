namespace CodeWarts.Infrastructure.Implementations.ClosestPairToNum;

public static class ClosestPairToNum
{
    public static (int a, int b) Execute(int limit)
    {
        var result = ClosesPair.Calculate(limit);
        return (result.Number1, result.Number2);
    }

    public static (int a, int b) Execute2(int limit)
    {
        var result = ClosesPair2.Calculate(limit);
        return result;
    }
    
    public static (int a, int b) Execute3(int limit)
    {
        var result = ClosesPair2.Calculate2(limit);
        return result;
    }
    
    public static (int a, int b) ExecuteRev2(int limit)
    {
        var result = ClosesPair2.CalculateRev(limit);
        return result;
    }
    
    public static (int a, int b) ExecuteRev3(int limit)
    {
        var result = ClosesPair2.CalculateRev2(limit);
        return result;
    }
}

public struct ClosesPair
{
    public int Limit { get; }
    public int Number1 { get; private set; }
    public int Number2 { get; private set; }

    private ClosesPair(int limit, int number1, int number2)
    {
        Limit = limit;
        Number1 = number1;
        Number2 = number2;
    }

    public static ClosesPair Calculate(int limit)
    {
        var result = FindCorrectResult(limit);
        if (!result.Correct)
            throw new InvalidOperationException($"Result was not calculated for limit: {limit}");
        return new ClosesPair(limit, result.Number1, result.Number2);
    }

    private static ClosesPairResult FindCorrectResult(int limit)
    {
        for (var i = limit - 1; i >= limit / 2; i--)
        {
            for (var j = i - 1; j > 0; j--)
            {
                var result = ClosesPairResult.Create(i, j);
                if (result.Correct)
                    return result;
            }
        }

        return ClosesPairResult.Create(1, 1);
    }
}

public struct ClosesPairResult
{
    public int Number1 { get; }
    public int Number2 { get; }
    public bool Correct { get; }

    private ClosesPairResult(int number1, int number2, bool correct)
    {
        Number1 = number1;
        Number2 = number2;
        Correct = correct;
    }

    public static ClosesPairResult Create(int number1, int number2) =>
        new(number1, number2, PerfectSquare.Check(number1 + number2) && PerfectSquare.Check(number1 - number2));
}

public struct ClosesPair2
{
    public static (int Number1, int Number2) Calculate(int limit)
    {
        var result = FindCorrectResult(limit);
        if (result.Number1 == 0)
            throw new InvalidOperationException($"Result was not calculated for limit: {limit}");
        return result;
    }
    
    public static (int Number1, int Number2) Calculate2(int limit)
    {
        var result = FindCorrectResult2(limit);
        if (result.Number1 == 0)
            throw new InvalidOperationException($"Result was not calculated for limit: {limit}");
        return result;
    }
    
    public static (int Number1, int Number2) CalculateRev(int limit)
    {
        var result = FindCorrectRevResult(limit);
        if (result.Number1 == 0)
            throw new InvalidOperationException($"Result was not calculated for limit: {limit}");
        return result;
    }
    
    public static (int Number1, int Number2) CalculateRev2(int limit)
    {
        var result = FindCorrectRevResult2(limit);
        if (result.Number1 == 0)
            throw new InvalidOperationException($"Result was not calculated for limit: {limit}");
        return result;
    }

    private static IEnumerable<int> CreateValues(int limit)
    {
        for (var i = 1; i * i < limit; i++)
        {
            yield return i * i;
        }
    }

    private static (int Number1, int Number2) FindCorrectResult(int limit)
    {
        var values = CreateValues(limit).ToList();
        for (var i = limit - 1; i >= limit / 2; i--)
        {
            foreach (var number in values.Where(x => x < i))
            {
                var result = i - number;
                if (PerfectSquare.Check(i + result))
                    return (i, result);
            }
        }

        return (0, 0);
    }

    private static (int Number1, int Number2) FindCorrectResult2(int limit)
    {
        foreach (var number in CreateValues(limit))
        {
            for (var i = limit - 1; i - number > 0; i--)
            {
                var result = i - number;
                if (PerfectSquare.Check(i + result))
                    return (i, result);
            }
        }

        return (0, 0);
    }
    
    private static (int Number1, int Number2) FindCorrectRevResult(int limit)
    {
        var values = CreateValues(limit).Reverse().ToList();
        for (var i = limit - 1; i >= limit / 2; i--)
        {
            foreach (var number in values.Where(x => x < i))
            {
                var result = i - number;
                if (PerfectSquare.Check(i + result))
                    return (i, result);
            }
        }

        return (0, 0);
    }

    private static (int Number1, int Number2) FindCorrectRevResult2(int limit)
    {
        foreach (var number in CreateValues(limit).Reverse())
        {
            for (var i = limit - 1; i - number > 0; i--)
            {
                var result = i - number;
                if (PerfectSquare.Check(i + result))
                    return (i, result);
            }
        }

        return (0, 0);
    }
}

public static class PerfectSquare
{
    public static bool Check(int number) =>
        Math.Sqrt(number) % 1 == 0;
}