using CodeWarts.Infrastructure.Implementations.AlphabeticalAddition;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class AlphabeticalAdditionTest
{
    [Test]
    public void Test()
    {
        Assert.AreEqual('f', AlphabeticalAddition.AddLetters(new char[] {'a', 'b', 'c'}));
        Assert.AreEqual('z', AlphabeticalAddition.AddLetters(new char[] {'z'}));
        Assert.AreEqual('c', AlphabeticalAddition.AddLetters(new char[] {'a', 'b'}));
        Assert.AreEqual('c', AlphabeticalAddition.AddLetters(new char[] {'c'}));
        Assert.AreEqual('a', AlphabeticalAddition.AddLetters(new char[] {'z', 'a'}));
        Assert.AreEqual('d', AlphabeticalAddition.AddLetters(new char[] {'y', 'c', 'b'}));
        Assert.AreEqual('z', AlphabeticalAddition.AddLetters(new char[] {}));
        
        Assert.AreEqual('c', AlphabeticalAddition.AddLetters(new char[] {'z', 'z', 'z','c'}));

    }
}