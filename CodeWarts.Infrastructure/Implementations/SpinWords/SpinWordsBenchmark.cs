using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.SpinWords;

[MemoryDiagnoser]
public class SpinWordsBenchmark
{
    private string _word =
        "ksak kskaklal alsdkasldka aklsdjaklsd alskdjaklsda aslkdjaklsdakjls aslkdjaklsdjakls oiausofiau oiajsdoiasj oiasjdoiaj oi aoisdjaosidjaoisd oijasdoiajsdoij oiajdsoajsdaosi oaijsdoasjdoaisdj oiajsdoaijsdoiajsd aoisdjaosidjaosidj adsasdasdasdasdasdasdasdasdasd";

    [Benchmark]
    public string Reverse() => SpinWords.Revers(_word);

    [Benchmark]
    public string ReverseSpan() => SpinWords.ReversSpan(_word);

    [Benchmark]
    public string Reverse2() => SpinWords.Revers2(_word);
}