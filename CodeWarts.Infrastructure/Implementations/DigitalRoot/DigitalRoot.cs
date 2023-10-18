namespace CodeWarts.Infrastructure.Implementations.DigitalRoot;

public class DigitalRoot
{
    public static int Calculate(long n)
    {
        var result = n.ToString().Select(x => x - '0').Sum();
        if (result < 10)
            return result;
        do
        {
            result = result.ToString().Select(x => x - '0').Sum();
        } while (result > 10);

        return result;
    }
}