using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Extensions;

[MemoryDiagnoser]
public class ArraySortBenchmark
{
    private int[] numbers;
    
    [GlobalSetup]
    public void SetUp()
    {
     var random = new Random(500);
     numbers = Enumerable.Range(1, 200).Select(x => random.Next()).ToArray();
    }
    
    [Benchmark]
    public int[] ArraySort()
    {
        Array.Sort(numbers);
        return numbers;
    }
    
    [Benchmark]
    public int[] SpanSort()
    {
        Span<int> arraySpan = numbers;
        arraySpan.Sort();
        return arraySpan.ToArray();
    }
}