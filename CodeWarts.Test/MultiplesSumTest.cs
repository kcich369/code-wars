using CodeWarts.Infrastructure.Implementations.MultiplesSum;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class MultiplesSumTest
{
    [Test]
    public void Test()
    {
        Assert.AreEqual(23,  MultiplesSum.SolutionBest(10)); //3,6,9,12,15,18,21,24,27,30   5,10,20,25
        Assert.AreEqual(195,  MultiplesSum.SolutionBest(30)); //3,6,9,12,15,18,21,24,27,30   5,10,20,25
        Assert.AreEqual(195,  MultiplesSum.SolutionDistinct(30)); //3,6,9,12,15,18,21,24,27,30   5,10,20,25
    }
}