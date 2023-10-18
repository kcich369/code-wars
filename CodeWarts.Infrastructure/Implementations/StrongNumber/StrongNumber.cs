using CodeWarts.Infrastructure.Extensions;

namespace CodeWarts.Infrastructure.Implementations.StrongNumber;

public class StrongNumber
{
    public static string Number(int a)
    {
        var numS = a.ToString();
        int sum = 0;
        for (int i = 0; i < numS.Length; i++)
        {
            sum += (int)Factorial.Calculate(numS[i] -'0');
        }

        return sum == a ? "STRONG!!!!" : "Not Strong !!";
    }
    
    public static string Number2(int a)
    {
        var numS = a.ToString();
        int sum = 0;
        for (int i = 0; i < numS.Length; i++)
        {
            sum += (int)Factorial.Calculate2(numS[i] -'0');
        }

        return sum == a ? "STRONG!!!!" : "Not Strong !!";
    }
}