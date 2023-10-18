using CodeWarts.Infrastructure.Implementations.PaginationHelper;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class PagnationHelperTests
{
    private readonly IList<int> collection = new List<int>
        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

    private PagnationHelper<int> helper;

    [SetUp]
    public void SetUp()
    {
        helper = new PagnationHelper<int>(collection, 10);
    }

    [TearDown]
    public void TearDown()
    {
        helper = null;
    }

    [Test]
    [TestCase(-1, ExpectedResult = -1)]
    [TestCase(1, ExpectedResult = 10)]
    [TestCase(2, ExpectedResult = 4)]
    [TestCase(3, ExpectedResult = -1)]
    public int PageItemCountTest(int pageIndex)
    {
        return helper.PageItemCount(pageIndex);
    }

    [Test]
    [TestCase(-1, ExpectedResult = -1)]
    [TestCase(12, ExpectedResult = 1)]
    [TestCase(23, ExpectedResult = 2)]
    [TestCase(24, ExpectedResult = -1)]
    public int PageIndexTest(int itemIndex)
    {
        return helper.PageIndex(itemIndex);
    }

    [Test]
    public void ItemCountTest()
    {
        Assert.AreEqual(24, helper.ItemCount);
    }

    [Test]
    public void PageCountTest()
    {
        Assert.AreEqual(3, helper.PageCount);
    }
}