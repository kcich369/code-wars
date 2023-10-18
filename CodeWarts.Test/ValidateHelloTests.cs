using CodeWarts.Infrastructure.Implementations.ValidateHello;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class ValidateHelloTests
{

    [Test]
    public void ValidTest()
    {
        Assert.IsTrue(ValidateHello.Validate("hello"));
        Assert.IsTrue(ValidateHello.Validate("ciao bella!"));
        Assert.IsTrue(ValidateHello.Validate("salut"));
        Assert.IsTrue(ValidateHello.Validate("hallo, salut"));
        Assert.IsTrue(ValidateHello.Validate("hombre! Hola!"));
        Assert.IsTrue(ValidateHello.Validate("Hallo, wie geht\'s dir?"));
        Assert.IsTrue(ValidateHello.Validate("AHOJ!"));
        Assert.IsTrue(ValidateHello.Validate("czesc"));
        Assert.IsTrue(ValidateHello.Validate("Ahoj"));
    }
    
    [Test]
    public void InvalidTest()
    {
        Assert.IsFalse(ValidateHello.Validate("meh"));
        Assert.IsFalse(ValidateHello.Validate("ehhh"));
        Assert.IsFalse(ValidateHello.Validate("elo"));
        Assert.IsFalse(ValidateHello.Validate("How old are you"));
    }
}