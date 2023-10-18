using CodeWarts.Infrastructure.Implementations.ConsecutiveDucks;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class ConsecutiveDucksTests
{
    [Test]
    // [TestCase(69, true)]
    // [TestCase(8, false)]
    // [TestCase(57, true)]
    // [TestCase(6, true)]
    // [TestCase(13, true)]
    // [TestCase(16, false)]
    // [TestCase(91, true)]
    // [TestCase(75, true)]
    // [TestCase(38, true)]
    [TestCase(25, true)]
    // [TestCase(32, false)]
    [TestCase(65, true)]
    [TestCase(13, true)]
    // [TestCase(16, false)]
    // [TestCase(99, true)]
    public void SmallValuesTest(int num, bool result)
    {
        Assert.AreEqual(result, ConsecutiveDucks.Execute(num));
    }
    
    [Test]
    // [TestCase(522, true)]
    // [TestCase(974, true)]
    // [TestCase(755, true)]
    // [TestCase(512, false)]
    // [TestCase(739, true)]
    // [TestCase(1006, true)]
    // [TestCase(838, true)]
    // [TestCase(1092, true)]
    // [TestCase(727, true)]
    // [TestCase(648, true)]
    // [TestCase(1024, false)]
    // [TestCase(851, true)]
    // [TestCase(541, true)]
    [TestCase(1011, true)]
    [TestCase(822, true)]
    public void MediumValuesTest(int num, bool result)
    {
        Assert.AreEqual(result, ConsecutiveDucks.Execute(num));
    }
    
    [Test]
    // [TestCase(382131, true)]
    // [TestCase(118070, true)]
    // [TestCase(17209, true)]
    // [TestCase(32768, false)]
    // [TestCase(161997, true)]
    // [TestCase(400779, true)]
    // [TestCase(198331, true)]
    // [TestCase(325482, true)]
    // [TestCase(88441, true)]
    // [TestCase(648, true)]
    [TestCase(65536, false)]
    // [TestCase(323744, true)]
    // [TestCase(183540, true)]
    [TestCase(65271, true)]
    // [TestCase(5263987, true)]
    public void LargeValuesTest(int num, bool result)
    {
        Assert.AreEqual(result, ConsecutiveDucks.Execute(num));
    }
}