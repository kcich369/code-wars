using CodeWarts.Infrastructure.Implementations.RowSumOddNumbers;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class RowSumOddNumbersTest
{
    [Test]
    public void Test()
    {
        Assert.AreEqual(8,RowSumOddNumbers.Calculate(2));
        Assert.AreEqual(74088,RowSumOddNumbers.Calculate(42));
    }
}