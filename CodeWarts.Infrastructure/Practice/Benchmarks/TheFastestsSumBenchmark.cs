using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Practice.Benchmarks;

[MemoryDiagnoser]
public class TheFastestsSumBenchmark
{
    public int[] numbers;

    [GlobalSetup]
    public void SetUp()
    {
        numbers = TheFastestSum.GetNumbers();
    }

    [Benchmark]
    public int SumFor() => TheFastestSum.SumFor(numbers);
    
    [Benchmark]
    public int SumFor4() => TheFastestSum.SumFor4(numbers);
    
    [Benchmark]
    public int SumFor4Span() => TheFastestSum.SumFor4Span(numbers);
    
    [Benchmark]
    public int SumLinq() => TheFastestSum.SumLinq(numbers);
    
    [Benchmark]
    public int SumSpanFor() => TheFastestSum.SumSpanFor(numbers);
    
    [Benchmark]
    public int SumSpanForEach() => TheFastestSum.SumSpanForEach(numbers);
    
    [Benchmark]
    public int SumForEach() => TheFastestSum.SumForEach(numbers);
    
    [Benchmark]
    public int SumForEachParallel() => TheFastestSum.SumForEachParallel(numbers);
    
    [Benchmark]
    public int SumForParallel() => TheFastestSum.SumForParallel(numbers);
}