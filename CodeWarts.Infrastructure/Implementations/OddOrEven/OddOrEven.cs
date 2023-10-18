using System.Collections;

namespace CodeWarts.Infrastructure.Implementations.OddOrEven;

public class OddOrEven
{
    public static string Process(int[] array) => array.Sum() % 2 == 0 ? "even" : "odd";

    public static string Process2(int[] array)
    {
        return Sum(array) % 2 == 0 ? "even" : "odd";
    }

    private static int Sum(int[] array)
    {
        var sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }
}