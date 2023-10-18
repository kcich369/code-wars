using CodeWarts.Infrastructure.Extensions;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class PrimeNumberTest
{
    [Test]
    public void Test()
    {
        Assert.AreEqual(true, PrimeNumber.IsPrime(983));
        Assert.AreEqual(true, PrimeNumber.IsPrime(991));
        Assert.AreEqual(true, PrimeNumber.IsPrime(997));
        Assert.AreEqual(false, PrimeNumber.IsPrime(1200));
        Assert.AreEqual(false, PrimeNumber.IsPrime(144));
    }
}