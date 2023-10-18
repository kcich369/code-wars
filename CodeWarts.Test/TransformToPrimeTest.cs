using CodeWarts.Infrastructure.Implementations;
using CodeWarts.Infrastructure.Implementations.TransformToPrime;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class TransformToPrimeTest
{
    [Test]
    public void Test()
    {
        Assert.AreEqual(1, TransformToPrime.MinimumNumber(new int[] { 3, 1, 2 }));
        Assert.AreEqual(0, TransformToPrime.MinimumNumber(new int[] { 5, 2 }));
        Assert.AreEqual(0, TransformToPrime.MinimumNumber(new int[] { 1, 1, 1 }));
        Assert.AreEqual(5, TransformToPrime.MinimumNumber(new int[] { 2, 12, 8, 4, 6 }));
        Assert.AreEqual(2, TransformToPrime.MinimumNumber(new int[] { 50, 39, 49, 6, 17, 28 }));
    }
}