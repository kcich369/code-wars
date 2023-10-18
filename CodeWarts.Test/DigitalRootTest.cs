using CodeWarts.Infrastructure.Implementations.DigitalRoot;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class DigitalRootTest
{
    [Test]
    public void Tests()
    {
        Assert.AreEqual(7, DigitalRoot.Calculate(16));
        Assert.AreEqual(6, DigitalRoot.Calculate(456));
        Assert.AreEqual(6, DigitalRoot.Calculate(54698756478));
    }
}