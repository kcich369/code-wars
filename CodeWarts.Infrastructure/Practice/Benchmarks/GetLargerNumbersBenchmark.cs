using BenchmarkDotNet.Attributes;
using CodeWarts.Infrastructure.Implementations.GetLargerNumbers;

namespace CodeWarts.Infrastructure.Practice.Benchmarks;

[MemoryDiagnoser]
public class GetLargerNumbersBenchmark
{
    public int[] a;
    public int[] b;

    [GlobalSetup]
    public void SetUp()
    {
        a = new int[] { 13, 64, 5, 7, 88, 13, 64, 5, 7, 88, 13, 64, 5, 7, 88 };
        b = new int[] { 23, 4, 53, 17, 80, 23, 4, 53, 17, 80, 23, 4, 53, 17, 80 };
    }

    [Benchmark]
    public int[] Execute() => GetLargerNumbers.Execute(a, b);

    [Benchmark]
    public int[] Execute2() => GetLargerNumbers.Execute2(a, b);
}