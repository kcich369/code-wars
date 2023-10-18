using CodeWarts.Infrastructure.Implementations.LongestRepetition;
using NUnit.Framework;

namespace CodeWarts.Test;

public class LongestRepetitionTests
{
    [Test]
    public void LongestAtTheBeginning()
    {
        Assert.AreEqual(new Tuple<char?, int> ('a', 4), LongestRepetition.Execute("aaaabb"));
        Assert.AreEqual(new Tuple<char?, int> ('b', 5), LongestRepetition.Execute("abbbbb"));
    }
    
    [Test]
    public void LongestAtTheEnd()
    {
        Assert.AreEqual(new Tuple<char?, int> ('a', 4), LongestRepetition.Execute("bbbaaabaaaa"));
        Assert.AreEqual(new Tuple<char?, int> ('x', 5), LongestRepetition.Execute("xxxyyybbbxxxxxaaabaaaa"));
    }
    
    [Test]
    public void LongestInTheMiddle()
    {
        Assert.AreEqual(new Tuple<char?, int> ('u', 3), LongestRepetition.Execute("cbdeuuu900"));
    }
    
    [Test]
    public void MultipleLongest()
    {
        Assert.AreEqual(new Tuple<char?, int> ('a', 2), LongestRepetition.Execute("aabb"));
        Assert.AreEqual(new Tuple<char?, int> ('b', 1), LongestRepetition.Execute("ba"));
    }
    
    [Test]
    public void EmptyString()
    {
        Assert.AreEqual(new Tuple<char?, int> (null, 0),  LongestRepetition.Execute(""));      
    }  
}