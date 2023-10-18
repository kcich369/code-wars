using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.OddOrEven;

[MemoryDiagnoser]
public class OddOrEvenBenchmark
{
    [Params(new int[]{65456,45,66546,564,6546,4654,321,3456,65465,3121321,4546,8496,4564,3213,456,6546})]
    public int[] array;

    [Benchmark]
    public string Sum1() => OddOrEven.Process(array);
    
    [Benchmark]
    public string Sum2() => OddOrEven.Process2(array);

}