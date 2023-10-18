using CodeWarts.Infrastructure.Implementations.OddOrEven;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class OddOrEvenTests
{
    [TestCase("even", new int[] { 0 })]
    [TestCase("odd", new int[] { 1 })]
    [TestCase("even", new int[] { })]
    public void EdgeTests(string result, int[] array)
    {
        Assert.AreEqual(result, OddOrEven.Process(array));
    }

    [TestCase("even", new int[] { 0, 1, 5 })]
    [TestCase("even", new int[] { 0, 1, 3 })]
    [TestCase("even", new int[] { 1023, 1, 2 })]
    public void EvenTests(string result, int[] array)
    {
        Assert.AreEqual(result, OddOrEven.Process(array));
    }

    [TestCase("even", new int[] { 0, -1, -5 })]
    [TestCase("even", new int[] { 0, -1, -3 })]
    [TestCase("even", new int[] { -1023, 1, -2 })]
    public void NegativeEvenTests(string result, int[] array)
    {
        Assert.AreEqual(result, OddOrEven.Process(array));
    }

    [TestCase("odd", new int[] { 0, 1, 2 })]
    [TestCase("odd", new int[] { 0, 1, 4 })]
    [TestCase("odd", new int[] { 1023, 1, 3 })]
    public void OddTests(string result, int[] array)
    {
        Assert.AreEqual(result, OddOrEven.Process(array));
    }

    [TestCase("odd", new int[] { 0, -1, 2 })]
    [TestCase("odd", new int[] { 0, 1, -4 })]
    [TestCase("odd", new int[] { -1023, -1, 3 })]
    public void NegativeOddTests(string result, int[] array)
    {
        Assert.AreEqual(result, OddOrEven.Process(array));
    }
}