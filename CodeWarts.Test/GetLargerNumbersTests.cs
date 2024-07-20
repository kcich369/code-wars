using CodeWarts.Infrastructure.Implementations.GetLargerNumbers;
using NUnit.Framework;

namespace CodeWarts.Test;

[TestFixture]
public class GetLargerNumbersTests
{
    [TestCase]
    public void Test()  
    {
        int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
        int[] arr2 = new int[] { 23, 4, 53, 17, 80 };
        Assert.AreEqual(GetLargerNumbers.Execute2(arr1,arr2) , new int[] {23, 64, 53, 17, 88});
    }
}