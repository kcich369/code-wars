using CodeWarts.Infrastructure.Implementations.ToCamelCase;
using NUnit.Framework;

namespace CodeWarts.Test;

public class ToCamelCaseTests
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual("theStealthWarrior", ToCamelCase.Execute("the_stealth_warrior"));
        Assert.AreEqual("TheStealthWarrior",ToCamelCase.Execute("The-Stealth-Warrior"));
    }
}