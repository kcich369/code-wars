namespace CodeWarts.Infrastructure.Extensions;

public class Factorial
{
    public static long Calculate(int number)
    {
        var result = 1;
        for (var i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    public static long Calculate2(int number)
    {
        return Enumerable.Range(1, number).Aggregate((i, r) => r * i);
    }

    public static long Calculate3(int number)
    {
        var result = 1;
        while (number > 1)
        {
            result *= number--;
        }

        return result;
    }
}