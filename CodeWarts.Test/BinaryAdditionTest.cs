using CodeWarts.Infrastructure.Implementations.BinaryAddition;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class BinaryAdditionTest
{
    [Test]
    public void TestExample()
    {
        Assert.AreEqual("110110000010", BinaryAddition.AddBinary(3250, 208));
        Assert.AreEqual("11000000111000001", BinaryAddition.AddBinary(64512, 34241));
        Assert.AreEqual("1101011011111", BinaryAddition.AddBinary(4537, 2342));
    }
}