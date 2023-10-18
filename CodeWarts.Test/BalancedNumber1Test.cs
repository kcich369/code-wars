﻿using CodeWarts.Infrastructure.Implementations.BalancedNumber1;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class BalancedNumber1Test
{
    // [TestCase(7, "Balanced")]
    // [TestCase(959, "Balanced")]
    // [TestCase(13, "Balanced")]
    [TestCase(56239814, "Balanced")]
    // [TestCase(424, "Balanced")]
    public void BalancedTests(int input, string expected)
    {
        Assert.That(BalancedNumber1.BalancedNumber2Sum(input), Is.EqualTo(expected));
    }
    [TestCase(1024, "Not Balanced")]
    [TestCase(66545, "Not Balanced")]
    [TestCase(295591, "Not Balanced")]
    [TestCase(1230987, "Not Balanced")]
    [TestCase(432, "Not Balanced")]
    public void NotBalancedTests(int input, string expected)
    {
        Assert.That(BalancedNumber1.BalancedNumber2Sum(input), Is.EqualTo(expected));
    }
}