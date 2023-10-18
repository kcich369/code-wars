using CodeWarts.Infrastructure.Implementations.HasSurvived;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class HasSurvivedTests
{
    // [TestCase(new[]{ 2, 9, 9, 7 }, new[] { 1, 1, 3, 8 }, false)]
    // [TestCase(new[]{ 1, 3, 5, 7 }, new[] { 2, 4, 6, 8 }, true)]
    // [TestCase(new[]{ 10, 10, 1, 1 }, new[] { 4, 4, 7, 7 }, true)]
    [TestCase(new int[0], new[] { 1, 2, 3 }, true)]
    [TestCase(new[]{ 1, 2, 3 }, new int[0], false)]
    [TestCase(new[]{ 10, 10, 1, 1,1 }, new[] { 4, 4, 7, 7 }, false)]
    [TestCase(new[]{ 10, 10, 1, 1 }, new[] { 4, 4, 7, 7,1 }, true)]
    // [TestCase(new[]{ 32,65,21,83,85,7,71,45,20,63 }, new[] { 83,44,38,55,84,80,58,20,4,74 }, false)]
    public void BasicTests(int[] attackers, int[] defenders, bool expected)
    {
        Assert.AreEqual(expected, HasSurvived.Process(attackers, defenders));
    }
}