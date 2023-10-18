using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.MaxTriSum;

[MemoryDiagnoser]
public class MaxTriSumBenchmart
{
    private int[] nums;

    [GlobalSetup]
    public void Setup()
    {
        // nums = "-13 -50 57 13 67 -13 57 108 67 -13 -50 57 13 67 -13 57 108 67".Split().Select(int.Parse).ToArray();
        nums =
            "-13 -50 57 13 67 -13 57 108 67 111 125 124 144 155 158 176 199 455 465 87 987 496 597 861 36 963 852 14 755 521 478 365 245 688 465 897 114 252 363 174 897 528 64 121 745 885 997 636 -13 -50 57 13 67 -13 57 108 67 111 125 124 144 155 158 176 199 455 465 87 987 496 597 861 36 963 852 14 755 521 478 365 245 688 465 897 114 252 363 174 897 528 64 121 745 885 997 636"
                .Split().Select(int.Parse).ToArray();
    }

    [Benchmark]
    public int Calculate() => MaxTriSum.Calculate(nums);

    [Benchmark]
    public int Calculate2() => MaxTriSum.Calculate2(nums);

    [Benchmark]
    public int Calculate3() => MaxTriSum.Calculate3(nums);
}