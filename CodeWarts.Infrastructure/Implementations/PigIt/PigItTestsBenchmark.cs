using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Implementations.PigIt;

public class PigItTestsBenchmark
{
    [Params(
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean sed mauris erat. Etiam nulla enim, pretium vel ipsum vitae, aliquet ornare nibh. Mauris at quam eu purus feugiat mollis nec a urna. Integer ut elementum metus. Nullam aliquet pulvinar augue, et malesuada orci condimentum vel. Fusce nec dictum mauris, sit amet aliquam dolor. Vestibulum eu auctor risus. In a velit fringilla, posuere orci blandit, consectetur eros. Sed mi nisl, vulputate vitae pharetra a, venenatis sed felis. Praesent maximus risus malesuada pellentesque eleifend. Nam odio lacus, finibus faucibus aliquam vel, efficitur quis velit. Nam nec nisl ut libero laoreet sagittis. Quisque.")]
    public string value;

    [Benchmark]
    public string Test1() => PigIt.Process(value);

    [Benchmark]
    public string Test2() => PigIt.Process2(value);
}