using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.RowWeights;

public class RowWeightsBenchmark
{
    private int[] a = new[] { 39, 84, 74, 18, 59, 72, 35, 61 };

    [Benchmark]
    public int[] Calc1() => RowWeights.Calculate(a);

    [Benchmark]
    public int[] Calc2() => RowWeights.Calculate2(a);
}