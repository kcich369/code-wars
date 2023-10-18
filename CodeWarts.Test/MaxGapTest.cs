using CodeWarts.Infrastructure.Implementations.MaxGap;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class MaxGapTest
{
    [Test, Description("Basic ToCamelCaseTests")]   
    [TestCase(new int[] { 13, 10, 2, 9, 5 }, ExpectedResult=4)]
    [TestCase(new int[] { 13, 3, 5 }, ExpectedResult=8)]
    [TestCase(new int[] { 24, 299, 131, 14, 26, 25 }, ExpectedResult=168)]
    [TestCase(new int[] { -3, -27, -4, -2 }, ExpectedResult=23)]
    [TestCase(new int[] { -7, -42, -809, -14, -12 }, ExpectedResult=767)]
    [TestCase(new int[] { 12, -5, -7, 0, 290 }, ExpectedResult=278)]
    [TestCase(new int[] { -54, 37, 0, 64, -15, 640, 0 }, ExpectedResult=576)]
    [TestCase(new int[] { 130, 30, 50 }, ExpectedResult=80)]
    [TestCase(new int[] { 1, 1, 1 }, ExpectedResult=0)]
    [TestCase(new int[] { -1, -1, -1 }, ExpectedResult=0)]
    public int BasicTests(int[] numbers)
    {
        return MaxGap.Result(numbers);
    }
}