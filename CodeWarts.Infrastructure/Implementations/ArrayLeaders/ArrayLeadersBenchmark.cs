using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.ArrayLeaders;

[MemoryDiagnoser]
public class ArrayLeadersBenchmark
{
    private int[] _numbers;

    [GlobalSetup]
    public void SetUp()
    {
        _numbers = new int[]
        {
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2,
            16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2, 16, 17, 4, 3, 5, 2
        };
    }

    [Benchmark()]
    public int[] Lead1() => ArrayLeaders.Calculate(_numbers);

    [Benchmark()]
    public int[] Lead2() => ArrayLeaders.Calculate2(_numbers);
}