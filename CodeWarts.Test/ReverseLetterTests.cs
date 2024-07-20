using CodeWarts.Infrastructure.Implementations.ReverseLetter;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class ReverseLetterTests
{
    
    [Test]
    public void BasicTests(){
        Assert.AreEqual("nahsirk",ReverseLetter.Execute("krishan"));
            
        Assert.AreEqual("nortlu",ReverseLetter.Execute("ultr53o?n"));
            
        Assert.AreEqual("cba",ReverseLetter.Execute("ab23c"));
            
        Assert.AreEqual("nahsirk",ReverseLetter.Execute("krish21an"));
            
    }
}