﻿using CodeWarts.Infrastructure.Implementations.StrongNumber;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class StrongNumberTest
{
    [TestCase(1, "STRONG!!!!")]
    [TestCase(2, "STRONG!!!!")]
    [TestCase(145, "STRONG!!!!")]
    [TestCase(7, "Not Strong !!")]
    [TestCase(93, "Not Strong !!")]
    [TestCase(185, "Not Strong !!")]
    public void BasicTests(int input, string expected)
    {
        Assert.That(StrongNumber.Number(input), Is.EqualTo(expected));
    }
}