using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.StrongNumber;

[MemoryDiagnoser()]
public class StrongNumberBenchmark
{
    [Benchmark]
    public string NumberFor() => StrongNumber.Number(185);
    
    [Benchmark]
    public string NumberAggregate() => StrongNumber.Number2(185);
}