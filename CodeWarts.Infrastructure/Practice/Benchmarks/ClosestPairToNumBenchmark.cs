using BenchmarkDotNet.Attributes;
using CodeWarts.Infrastructure.Implementations.ClosestPairToNum;

namespace CodeWarts.Infrastructure.Practice.Benchmarks;

[MemoryDiagnoser]
public class ClosestPairToNumBenchmark
{
    [Params(1, 10, 30, 50, 80, 100, 250, 500, 2000, 10000)]
    public int Limit { get; set; }

    [Benchmark]
    public (int, int) Execute() => ClosestPairToNum.Execute(Limit);


    [Benchmark]
    public (int, int) Execute2() => ClosestPairToNum.Execute2(Limit);


    [Benchmark]
    public (int, int) Execute3() => ClosestPairToNum.Execute3(Limit);


    [Benchmark]
    public (int, int) ExecuteRev2() => ClosestPairToNum.ExecuteRev2(Limit);


    [Benchmark]
    public (int, int) ExecuteRev3() => ClosestPairToNum.ExecuteRev3(Limit);
}