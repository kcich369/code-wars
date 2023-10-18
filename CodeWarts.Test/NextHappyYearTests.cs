using CodeWarts.Infrastructure.Implementations.NextHappyYear;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class NextHappyYearTests
{
    [Test]
    public void BasicValues()
    {
        Assert.AreEqual(NextHappyYear.Get(1001), 1023);
        Assert.AreEqual(NextHappyYear.Get(1123), 1203);
        Assert.AreEqual(NextHappyYear.Get(2001), 2013);
        Assert.AreEqual(NextHappyYear.Get(2334), 2340);
        Assert.AreEqual(NextHappyYear.Get(3331), 3401);
        Assert.AreEqual(NextHappyYear.Get(2342), 2345);
        Assert.AreEqual(NextHappyYear.Get(1987), 2013);
        Assert.AreEqual(NextHappyYear.Get(2013), 2014);
        Assert.AreEqual(NextHappyYear.Get(3000), 3012);
    }
    
    [Test]
    public void LargeValues()
    {
        Assert.AreEqual(NextHappyYear.Get(5555), 5601);
        Assert.AreEqual(NextHappyYear.Get(7712), 7801);
        Assert.AreEqual(NextHappyYear.Get(8088), 8091);
        Assert.AreEqual(NextHappyYear.Get(8800), 8901);
        Assert.AreEqual(NextHappyYear.Get(8989), 9012);
        Assert.AreEqual(NextHappyYear.Get(8977), 9012);
        Assert.AreEqual(NextHappyYear.Get(6869), 6870);
        Assert.AreEqual(NextHappyYear.Get(8999), 9012);
    }
}