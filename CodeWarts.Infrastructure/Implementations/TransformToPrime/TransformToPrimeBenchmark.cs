using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations;

[MemoryDiagnoser]
public class TransformToPrimeBenchmark
{
    [Benchmark]
    public void MinimumNumber() => TransformToPrime.TransformToPrime.MinimumNumber(new []{200,300,400,90,7});
    
    [Benchmark]
    public void MinimumNumberBest() => TransformToPrime.TransformToPrime.MinimumNumberBest(new []{200,300,400,90,7});
}