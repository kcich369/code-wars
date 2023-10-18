using CodeWarts.Infrastructure.Practice;
using NUnit.Framework;

namespace CodeWarts.Test.Practice;

[TestFixture]
public class TheFastestsSumTests
{
    // private List<int> numbers;
    // private ulong sum;
    //
    // [OneTimeSetUp]
    // protected void SetUp()
    // {
    //     numbers = TheFastestSum.GetNumbers().ToList();
    //     sum = (ulong)numbers.Sum();
    // }

    [Test]
    public void SumForTest()
    {
        var numbers = TheFastestSum.GetNumbers().ToList();
        
        var result = TheFastestSum.SumFor(numbers.ToArray());
        
        Assert.AreEqual(numbers.Sum(), result);
    }
    
    [Test]
    public void SumFor4Test()
    {
        var numbers = TheFastestSum.GetNumbers().ToList();
        
        var result = TheFastestSum.SumFor(numbers.ToArray());
        
        Assert.AreEqual(numbers.Sum(), result);
    }
    
    [Test]
    public void SumLinqTest()
    {
        var numbers = TheFastestSum.GetNumbers().ToList();
        
        var result = TheFastestSum.SumLinq(numbers.ToArray());
        
        Assert.AreEqual(numbers.Sum(), result);
    }
    
    [Test]
    public void SumSpanTest()
    {
        var numbers = TheFastestSum.GetNumbers().ToList();
        
        var result = TheFastestSum.SumSpanFor(numbers.ToArray());
        
        Assert.AreEqual(numbers.Sum(), result);
    }
    
    [Test]
    public void SumForEachTest()
    {
        var numbers = TheFastestSum.GetNumbers().ToList();
        
        var result = TheFastestSum.SumForEach(numbers.ToArray());
        
        Assert.AreEqual(numbers.Sum(), result);
    }
}