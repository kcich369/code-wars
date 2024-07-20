namespace CodeWarts.Infrastructure.Implementations.ReverseLetter;

public class ReverseLetter
{
    public static string Execute(string str)
    {
        return new string(str.Reverse().Where(x => (int)x is > 96 and < 123).ToArray());
    }

    public static string Execute2(string str)
    {
        return new string(str.Reverse().Select(Check).Where(x => x != '0').ToArray());
    }

    private static char Check(char element)
    {
        var value = (int)element;
        return value is > 96 and < 123 ? element : '0';
    }
}