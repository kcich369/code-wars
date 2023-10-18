using CodeWarts.Infrastructure.Implementations.JumpingNumber;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class JumpingNumberTest
{
    [TestCase(1)]
    [TestCase(7)]
    [TestCase(9)]
    [TestCase(23)]
    [TestCase(32)]
    [TestCase(98)]
    [TestCase(8987)]
    [TestCase(4343456)]
    [TestCase(98789876)]
    public void BasicJumpingNumbers(int number)
    {
        Assert.That(JumpingNumber.IsJumpingNumber(number), Is.EqualTo("Jumping!!"));
    }
    [TestCase(00000079)]
    // [TestCase(12346)]
    // [TestCase(5645)]
    public void BasicNotNumbers(int number)
    {
        Assert.That(JumpingNumber.IsJumpingNumber(number), Is.EqualTo("Not!!"));
    }
}