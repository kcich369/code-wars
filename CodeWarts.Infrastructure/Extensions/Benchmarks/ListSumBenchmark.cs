﻿using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Extensions.Benchmarks;

public class ListSumBenchmark
{
    private List<int> _numbers;

    [GlobalSetup]
    public void Setup()
    {
        _numbers = new int[]
        {
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
            2541, 25514, 185, 548, 56, 211, 6498, 2156, 5122, 56
        }.ToList();
    }

    [Benchmark]
    public int CalculateFor() => ListSum.CalculateFor(_numbers);

    [Benchmark]
    public int CalculateForEach() => ListSum.CalculateForEach(_numbers);

    [Benchmark]
    public int CalculateLinq() => ListSum.CalculateLinq(_numbers);
}