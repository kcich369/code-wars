using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.MultiplesSum;

[MemoryDiagnoser]
public class MultiplesSumBenchmark
{
    [Benchmark]
    public int Sum() => MultiplesSum.Solution(1000);
    
    [Benchmark]
    public int DistinctSum() => MultiplesSum.SolutionDistinct(1000);
    
    [Benchmark]
    public int SumEnumerable() => MultiplesSum.SolutionBest(1000);
    //
    // [Benchmark]
    // public int DistinctSumArray() => MultiplesSum.SolutionArrayDistinct(1000);
    //
    // [Benchmark]
    // public int SolutionArrayListCast() => MultiplesSum.SolutionArrayListCast(1000);
    //
    // [Benchmark]
    // public int SolutionArrayListOfType() => MultiplesSum.SolutionArrayListOfType(1000);
    //
    // [Benchmark]
    // public int SolutionDistinctArrayListCast() => MultiplesSum.SolutionDistinctArrayListCast(1000);
    //
    // [Benchmark]
    // public int SolutionDistinctArrayListOfType() => MultiplesSum.SolutionDistinctArrayListOfType(1000);
}