using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.BinaryAddition;

[MemoryDiagnoser]
public class BinaryAdditionBenchmark
{
    [Benchmark]
    public string Convert() => BinaryAddition.AddBinary(64512, 34241);
    
    [Benchmark]
    public string ConvertBest() => BinaryAddition.AddBinaryBest(64512, 34241);
}