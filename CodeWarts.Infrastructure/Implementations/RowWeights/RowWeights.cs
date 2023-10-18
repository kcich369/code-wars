namespace CodeWarts.Infrastructure.Implementations.RowWeights;

public class RowWeights
{
    public static int[] Calculate(int[] a)
    {
        var teams = a.Select((x, i) => i % 2 == 0 ? (x, 0) : (0, x)).ToList();
        return new[] { teams.Select(x => x.Item1).Sum(), teams.Select(x => x.Item2).Sum() };
    }

    public static int[] Calculate2(int[] a)
    {
        return new[] { a.Where((x, i) => i % 2 == 0).Sum(), a.Where((x, i) => i % 2 == 1).Sum() };
    }
}