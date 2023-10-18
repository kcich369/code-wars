namespace CodeWarts.Infrastructure.Implementations.MaxMultiply;

public static class MaxMultiply
{
    public static int Find(int divisor, int bound)
    {
        while (bound % divisor != 0)
        {
            bound--;
        }
        return bound;
    }
}