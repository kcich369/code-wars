namespace CodeWarts.Infrastructure.Implementations.DisariumNumber;

public class DisariumNumber
{
    public static string Calculate(int number)
    {
        var numS = number.ToString();
        var sum = 0;
        for (int i = 1; i <= numS.Length; i++)
        {
            sum += (int)Math.Pow(numS[i - 1] - '0', i);
        }
        return number== sum ?  "Disarium !!" : "Not !!";
    }

}