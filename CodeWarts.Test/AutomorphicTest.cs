using CodeWarts.Infrastructure.Implementations.Automorphic;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class AutomorphicTest
{
    [TestCase(1, "Automorphic")]
    [TestCase(3, "Not!!")]
    [TestCase(6, "Automorphic")]
    [TestCase(9, "Not!!")]
    [TestCase(25, "Automorphic")]
    [TestCase(53, "Not!!")]
    [TestCase(76, "Automorphic")]
    [TestCase(95, "Not!!")]
    [TestCase(625, "Automorphic")]
    [TestCase(225, "Not!!")]
    public void BasicTests(int n, string expected)
    {
        Assert.That(Automorphic.Calculate(n), Is.EqualTo(expected));
    }
}