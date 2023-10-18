using CodeWarts.Infrastructure.Implementations.DisariumNumber;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class DisariumNumberTest
{
    [TestCase(89, "Disarium !!")]
    [TestCase(564, "Not !!")]
    [TestCase(1024, "Not !!")]
    [TestCase(135, "Disarium !!")]
    [TestCase(136586, "Not !!")]
    public void BasicTests(int number, string expected)
    {
        Assert.That(DisariumNumber.Calculate(number), Is.EqualTo(expected));
    }
}