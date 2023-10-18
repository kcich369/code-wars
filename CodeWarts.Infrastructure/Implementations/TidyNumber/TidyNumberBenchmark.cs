using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.TidyNumber;

[MemoryDiagnoser]
public class TidyNumberBenchmark
{
    // [Params(12345,1579, 123456789)]
    // [Params(12345698, 123456798)]
    [Params(987654321)]
    public int Number { get; set; }
    [Benchmark]
    public bool Num1() => TidyNumber.Number(Number);
    
    [Benchmark]
    public bool Num2() => TidyNumber.Number1(Number);
}