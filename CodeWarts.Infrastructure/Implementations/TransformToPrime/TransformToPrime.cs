using CodeWarts.Infrastructure.Extensions;

namespace CodeWarts.Infrastructure.Implementations.TransformToPrime;

public static class TransformToPrime
{
    public static int MinimumNumber(int[] numbers)
    {
        var sum = numbers.Sum();
        var number = sum;
        while (true)
        {
            if (PrimeNumber.IsPrime(number))
            {
                return number - sum;
            }
            number++;
        }        
    }
    
    public static int MinimumNumberBest(int[] numbers)
    {
        for (int i = numbers.Sum(); ; i++)
            if (!Enumerable.Range(2, (int)Math.Sqrt(i)).Any(divisor => i % divisor == 0))
                return i - numbers.Sum();
    }
}