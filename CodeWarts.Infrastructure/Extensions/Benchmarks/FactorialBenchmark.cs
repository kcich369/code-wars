using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Extensions.Benchmarks;

[MemoryDiagnoser]
public class FactorialBenchmark
{
    [Benchmark]
    public long Calculate() => Factorial.Calculate(15);
    
    [Benchmark]
    public long Calculate2() => Factorial.Calculate2(15);
    
    [Benchmark]
    public long Calculate3() => Factorial.Calculate3(15);
}