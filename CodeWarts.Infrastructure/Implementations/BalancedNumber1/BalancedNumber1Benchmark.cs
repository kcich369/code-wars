using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.BalancedNumber1;

[MemoryDiagnoser]
public class BalancedNumber1Benchmark
{
    [Benchmark]
    public string My() => BalancedNumber1.BalancedNumber(879458794);
    
    [Benchmark]
    public string My2() => BalancedNumber1.BalancedNumber2(879458794);
    
    [Benchmark]
    public string My2Sum() => BalancedNumber1.BalancedNumber2Sum(879458794);
    
    [Benchmark]
    public string Best1() => BalancedNumber1.BalancedNumberBest1(879458794);
    
    [Benchmark]
    public string Best2() => BalancedNumber1.BalancedNumberBest2(879458794);
    
    [Benchmark]
    public string Other1() => BalancedNumber1.BalancedNumberOther1(879458794);
    
    [Benchmark]
    public string Other2() => BalancedNumber1.BalancedNumberOther2(879458794);
}