namespace CodeWarts.Infrastructure.Implementations.ValidParentheses;

public static class ValidParentheses
{
    public static bool IsValid(string str)
    {
        var sum = 0;
        foreach (var value in str.Select(x => x == '(' ? 1 : -1))
        {
            sum += value;
            if (sum < 0)
                return false;
        }
        return sum == 0;
    }
}