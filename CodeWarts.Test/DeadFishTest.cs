using CodeWarts.Infrastructure.Implementations;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class DeadFishTest
{
    private static object[] sampleTestCases = new object[]
    {
        new object[] {"iiisdoso", new int[] {8, 64}},
        new object[] {"iiisdosodddddiso", new int[] {8, 64, 3600}},
    };
  
    [Test, TestCaseSource("sampleTestCases")]
    public void SampleTest(string data, int[] expected)
    {
        Assert.AreEqual(expected, DeadFish.Parse(data));
    }
}