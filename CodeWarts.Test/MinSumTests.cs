using CodeWarts.Infrastructure.Implementations.MinSum;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class MinSumTests
{
    [TestCase(2, 1, 2)]
    [TestCase(22, 5, 4, 2, 3)]
    [TestCase(342, 12, 6, 10, 26, 3, 24)]
    [TestCase(74, 9, 2, 8, 7, 5, 4, 0, 6)]
    public void BasicTests(int expected, params int[] a)
    {
        Assert.That(MinSum.Get(a), Is.EqualTo(expected));
    }

    [Test]
    public void EmptyInput()
    {
        Assert.That(MinSum.Get(new int[] { }), Is.EqualTo(0));
    }
}