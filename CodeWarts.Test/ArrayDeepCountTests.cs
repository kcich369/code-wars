using CodeWarts.Infrastructure.Implementations.ArrayDeepCount;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class ArrayDeepCountTests
{
    private static object[] Basic_Test_Cases = new object[]
    {
        new object[]
        {
            new object[] {},
            0
        },
        new object[]
        {
            new object[] {1, 2, 3},
            3
        },
        new object[]
        {
            new object[] {"x", "y", new object[] {"z"}},
            4
        },
        new object[]
        {
            new object[] {1, 2, new object[] {3, 4, new object[] {5}}},
            7
        },
        new object[]
        {
            new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] {}}}}}}}}},
            8
        }
    };
  
    [Test, TestCaseSource(typeof(ArrayDeepCountTests), "Basic_Test_Cases")]
    public void Basic_Tests(object test, int expected)
    {
        Assert.AreEqual(expected, ArrayDeepCount.Count(test), $"Expected {expected}");
    }
}