using CodeWarts.Infrastructure.Implementations.NumbersOfLetters;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class NumbersOfLettersTests
{
    [TestCase(1, new string[] { "one", "three", "five", "four" })]
    [TestCase(12, new string[] { "onetwo", "six", "three", "five", "four" })]
    [TestCase(37, new string[] { "threeseven", "onezero", "seven", "five", "four" })]
    [TestCase(311, new string[] { "threeoneone", "oneone", "six", "three", "five", "four" })]
    [TestCase(999, new string[] { "nineninenine", "onetwo", "six", "three", "five", "four" })]
    public void Test(int number, string[] result)
    {
        Assert.AreEqual(result, NumbersOfLetters.Execute(number));
    }
}