using CodeWarts.Infrastructure.Implementations.DeclareWinner;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class DeclareWinnerTests
{
    [Test]
    public void BasicTests() {
        Assert.AreEqual("Lew", DeclareWinner.Fight(new Fighter("Lew", 10, 2),new Fighter("Harry", 5, 4), "Lew"));
        Assert.AreEqual("Harry", DeclareWinner.Fight(new Fighter("Lew", 10, 2),new Fighter("Harry", 5, 4), "Harry"));
        Assert.AreEqual("Harald", DeclareWinner.Fight(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry"));        
        Assert.AreEqual("Harald", DeclareWinner.Fight(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald"));        
        Assert.AreEqual("Harald", DeclareWinner.Fight(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"));            
        Assert.AreEqual("Harald", DeclareWinner.Fight(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Harald"));
        
    }
}