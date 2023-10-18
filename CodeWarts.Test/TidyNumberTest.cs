using CodeWarts.Infrastructure.Implementations.TidyNumber;
using NUnit.Framework;

namespace CodeWarts.Test;

public class TidyNumberTest
{
    [TestCase(12)]
    [TestCase(2789)]
    [TestCase(2335)]
    [TestCase(123456789)]
    [TestCase(12345678)]
    public void BasicTestsTrue(int n)
    {
        Assert.IsTrue(TidyNumber.Number(n));
    }
    
    [TestCase(102)]
    [TestCase(9672)]
    [TestCase(12345687)]
    [TestCase(123456798)]
    public void BasicTestsFalse(int n)
    {
        Assert.IsFalse(TidyNumber.Number(n));
    }
}