namespace CodeWarts.Infrastructure.Implementations.BinaryAddition;

public class BinaryAddition
{
    public static string AddBinary(int a, int b)
    {
        var sum = (double)(a + b); 
        var log = (int)Math.Log2(sum);
        return CreateBinaryNumberAsString(log, sum - Math.Pow(2, log));
    }

    public static string AddBinaryBest(int a, int b)
    {
        return Convert.ToString(a + b, 2);
    }
    
    private static string CreateBinaryNumberAsString(int log, double sum)
    {
        var byteChars = new char[log + 1];
        byteChars[0] = '1';
        var power = log;
        for (var i = 1; i <= log; i++)
        {
            power--;
            var value = Math.Pow(2, power);
            if (value > sum)
            {
                byteChars[i] = '0';
                continue;
            }
            byteChars[i] = '1';
            sum -= value;
        }

        return new string(byteChars);
    }
}