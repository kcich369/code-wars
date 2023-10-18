using CodeWarts.Infrastructure.Implementations.MaxProduct;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class MaxProductTests
{
    [Test]
    public void BasicTests() {
        Assert.AreEqual(20, MaxProduct.Get(new int[] { 4, 3, 5 }, 2));
        Assert.AreEqual(720, MaxProduct.Get(new int[] { 10, 8, 7, 9 }, 3));
        Assert.AreEqual(288, MaxProduct.Get(new int[] { 8, 6, 4, 6 }, 3));
        Assert.AreEqual(9600,MaxProduct.Get(new int[] { 10, 2, 3, 8, 1, 10, 4 }, 5));
        Assert.AreEqual(247895375,MaxProduct.Get(new int[] { 13, 12, -27, -302, 25, 37, 133, 155, -14 }, 5));
        Assert.AreEqual(4, MaxProduct.Get(new int[] { -4, -27, -15, -6, -1 }, 2));
        Assert.AreEqual(136,MaxProduct.Get(new int[] { -17, -8, -102, -309 }, 2));
        Assert.AreEqual(-30,MaxProduct.Get(new int[] { 10, 3, -27, -1 }, 3));
        Assert.AreEqual(-253344,MaxProduct.Get(new int[] { 14, 29, -28, 39, -16, -48 }, 4));
        Assert.AreEqual(1, MaxProduct.Get(new int[] { 1 }, 1));
    }
}