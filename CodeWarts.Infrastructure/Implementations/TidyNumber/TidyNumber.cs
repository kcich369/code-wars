namespace CodeWarts.Infrastructure.Implementations.TidyNumber;

public class TidyNumber
{
    public static bool Number(int n)
    {
        var numbers = n.ToString().ToArray();
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (i == 0)
                continue;
            if (numbers[i]- '0' < numbers[i - 1]- '0')
                return false;
        }
        return true;
    }
    
    public static bool Number1(int n)
    {
        return n.ToString() == String.Concat(n.ToString().OrderBy(c => c));
    }
}