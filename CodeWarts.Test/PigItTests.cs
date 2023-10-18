using CodeWarts.Infrastructure.Implementations.PigIt;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class PigItTests
{
    [Test]
    public void KataTests()
    {
        Assert.AreEqual("igPay atinlay siay oolcay", PigIt.Process("Pig latin is cool"));
        Assert.AreEqual("hisTay siay ymay tringsay", PigIt.Process("This is my string"));
    }
}