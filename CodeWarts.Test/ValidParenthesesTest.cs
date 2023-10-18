using CodeWarts.Infrastructure.Implementations.ValidParentheses;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class ValidParenthesesTest
{
    [TestCase(true, "()")]
    [TestCase(true, "((()))")]
    [TestCase(true, "()()()")]
    [TestCase(true, "(()())()")]
    [TestCase(true, "")]
    public void ValidTest(bool result, string parentheses)
    {
        Assert.AreEqual(result, ValidParentheses.IsValid(parentheses));
    }

    [TestCase(false, ")(")]
    [TestCase(false, "()()(")]
    [TestCase(false, "((())")]
    [TestCase(false, "())(()")]
    [TestCase(false, "())(()")]
    [TestCase(false, ")()")]
    [TestCase(false, ")")]
    public void InvalidTest(bool result, string parentheses)
    {
        Assert.AreEqual(result, ValidParentheses.IsValid(parentheses));
    }
}