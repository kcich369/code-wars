using CodeWarts.Infrastructure.Implementations.SpinWords;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class SpinWordsTest
{
    [Test]
    public static void Test1()
    {
        Assert.AreEqual("emocleW", SpinWords.Revers("Welcome"));
    }

    [Test]
    public static void Test2()
    {
        Assert.AreEqual("Hey wollef sroirraw", SpinWords.Revers("Hey fellow warriors"));
    }

    [Test]
    public static void Test3()
    {
        Assert.AreEqual("This is a test", SpinWords.Revers("This is a test"));
    }

    [Test]
    public static void Test4()
    {
        Assert.AreEqual("This is rehtona test", SpinWords.Revers("This is another test"));
    }

    [Test]
    public static void Test5()
    {
        Assert.AreEqual("You are tsomla to the last test", SpinWords.Revers("You are almost to the last test"));
    }

    [Test]
    public static void Test6()
    {
        Assert.AreEqual("Just gniddik ereht is llits one more", SpinWords.Revers("Just kidding there is still one more"));
    }
}