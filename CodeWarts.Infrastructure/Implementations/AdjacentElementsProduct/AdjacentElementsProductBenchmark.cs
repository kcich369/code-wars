using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.AdjacentElementsProduct;

[MemoryDiagnoser]
public class AdjacentElementsProductBenchmark
{
    [Params(new int[] { -23, 4, -5, 99, -27, 329, -2, 7, -921 })]
    public int[] array;

    [Benchmark]
    public int Test1() => AdjacentElementsProduct.Product(array);
    
    [Benchmark]
    public int Test2() => AdjacentElementsProduct.Product2(array);
    
    [Benchmark]
    public int Test3() => AdjacentElementsProduct.Product3(array);
}