using CodeWarts.Infrastructure.Implementations.ClosestPairToNum;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class ClosestPairToNumTests
{

    [TestCase(10, 5,4)]
    [TestCase(30, 29,20)]
    [TestCase(50, 45,36)]
    [TestCase(70, 68,32)]
    [TestCase(90, 89,80)]
    public void Test(int limit, int res1, int res2)
    {
        Assert.AreEqual((res1, res2), ClosestPairToNum.Execute(limit));
    }
    
    [TestCase(10, 5,4)]
    [TestCase(30, 29,20)]
    [TestCase(50, 45,36)]
    [TestCase(70, 68,32)]
    [TestCase(90, 89,80)]
    public void Test2(int limit, int res1, int res2)
    {
        Assert.AreEqual((res1, res2), ClosestPairToNum.Execute2(limit));
    }
    
    [TestCase(10, 5,4)]
    [TestCase(30, 29,20)]
    [TestCase(50, 45,36)]
    [TestCase(70, 68,32)]
    [TestCase(90, 89,80)]
    public void Test3(int limit, int res1, int res2)
    {
        // Assert.AreEqual((res1, res2), ClosestPairToNum.Execute3(limit));
        // var a1 = ClosestPairToNum.Execute(1000);
        // var a2 = ClosestPairToNum.Execute2(1000);
        // var a3 = ClosestPairToNum.Execute3(1000);
        var a4 = ClosestPairToNum.ExecuteRev2(10);
        var a5 = ClosestPairToNum.ExecuteRev3(10);
    }
}