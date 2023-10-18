namespace CodeWarts.Infrastructure.Implementations.JumpingNumber;

public class JumpingNumber
{
    public static string IsJumpingNumber(int number)
    {
        var numS = number.ToString();
        for (var i = 0; i < numS.Length - 1; i++)
        {
            var diff = (numS[i] - '0') - (numS[i + 1] - '0');
            if (Math.Abs(diff) != 1)
                return "Not!!";
        }

        return "Jumping!!";
    }
}