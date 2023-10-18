using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Extensions.Benchmarks;

[MemoryDiagnoser]
public class NumberToStringBenchmark
{
    private int number;
    [GlobalSetup]
    public void SetUp()
    {
        number = 1239876454;
    }

    [Benchmark]
    public string NumberToString() => number.ToString();
    
    [Benchmark]
    public string NumberToStringWithDolar() => $"number";
}