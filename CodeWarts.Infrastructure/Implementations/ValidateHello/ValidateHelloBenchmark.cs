using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.ValidateHello;

[MemoryDiagnoser]
public class ValidateHelloBenchmark
{
    [Params("hola amigos !", "asdasd adasdasd asdasdasd asdasda asdasdasdasd asdasd adasdasd asdasdasd asdasda czesc asdasdasdasd",
        "asd daads dsaads dsa dsasad ahoj","hallo", "hello", "asd", "czesc")]
    public string value;
    
    [Benchmark]
    public bool ContainsLinq() => ValidateHello.Validate(value);
    
    [Benchmark]
    public bool ContainsSpan() => ValidateHello.Validate3(value);
    
    [Benchmark]
    public bool ContainsFor() => ValidateHello.Validate2(value);
    
    [Benchmark]
    public bool ContainsRegex() => ValidateHello.Validate4(value);
}