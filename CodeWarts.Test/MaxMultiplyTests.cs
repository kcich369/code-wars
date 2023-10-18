using CodeWarts.Infrastructure.Implementations.MaxMultiply;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class MaxMultiplyTests
{
    [TestCase(2, 7, 6)]
    [TestCase(3, 10, 9)]
    [TestCase(7, 17, 14)]
    public void SmallNumbers(int divisor, int bound, int ex)
    {
        Assert.That(MaxMultiply.Find(divisor, bound), Is.EqualTo(ex));
    }
    [TestCase(10, 50, 50)]
    [TestCase(37, 200, 185)]
    [TestCase(7, 100, 98)]
    public void LargeNumbers(int divisor, int bound, int ex)
    {
        Assert.That(MaxMultiply.Find(divisor, bound), Is.EqualTo(ex));
    }
}