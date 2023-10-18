using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.MinNumFromArray;

[MemoryDiagnoser]
public class MinNumFromArrayBenchmark
{
    private int[] arr;

    [GlobalSetup]
    public void SetUp()
    {
        arr = new[]
        {
            9, 8, 9, 7, 8, 6, 5, 6, 4, 8, 7, 6, 5, 4, 3, 2, 1, 5, 6, 4, 8, 7, 9, 3, 4, 6, 5, 8, 7, 9, 8, 5, 4, 2, 3, 4,
            5, 4, 7, 8, 9, 5, 4, 3, 5, 4, 6, 9, 8, 8
        };
    }

    [Benchmark]
    public long Min1() => MinNumFromArray.MinValue(arr);

    [Benchmark]
    public long Min2() => MinNumFromArray.MinValue2(arr);

    [Benchmark]
    public long Min3() => MinNumFromArray.MinValue3(arr);
}