namespace CodeWarts.Infrastructure.Extensions;

public static class PrimeNumber
{
    public static bool IsPrime(int number)
    {
        var dvd = 2;
        while (dvd <= (int)Math.Sqrt(number))
        {
            if (number % dvd == 0)
                return false;
            dvd++;
        }
        return true;
    }
}