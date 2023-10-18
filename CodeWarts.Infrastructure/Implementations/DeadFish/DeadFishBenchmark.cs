using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations;

[MemoryDiagnoser]
public class DeadFishBenchmark
{
    [Benchmark]
    public  int[] Parse() => DeadFish.Parse("iiisdosodddddiso");
    
    [Benchmark]
    public  int[] ParseDictionary() => DeadFish.ParseDictionary("iiisdosodddddiso");
    
    [Benchmark]
    public  int[] ParseList() => DeadFish.ParseList("iiisdosodddddiso");
}