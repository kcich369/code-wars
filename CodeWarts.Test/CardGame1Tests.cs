using CodeWarts.Infrastructure.Implementations.CardGame;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class CardGame1Tests
{
    [Test]
    public static void GoodDay()
    {
        Assert.AreEqual(true,
            CardGame1.Game(new int[4] { 2, 5, 8, 11 }, new int[4] { 1, 4, 7, 10 }, new int[4] { 0, 3, 6, 9 }));
    }

    [Test]
    public static void BadDay()
    {
        // Assert.AreEqual(false,
        //     CardGame1.Game(new int[4] { 1, 2, 3, 4 }, new int[4] { 5, 6, 7, 8 }, new int[4] { 0, 9, 10, 11 }));
        Assert.AreEqual(false,
            CardGame1.Game(new int[4] { 1, 2, 3, 4 }, new int[4] { 0, 9, 10, 11 }, new int[4] { 5, 6, 7, 8 }));
    }
}