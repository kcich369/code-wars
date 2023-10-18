using System.Text.RegularExpressions;

namespace CodeWarts.Infrastructure.Implementations.ValidateHello;

public static class ValidateHello
{
    private static string[] _vaildGreetings = new[] { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };

    public static bool Validate(string value) => value.Contains(_vaildGreetings);

    private static bool Contains(this string stringVal, string[] values) =>
        values.Any(x => stringVal.Contains(x, StringComparison.InvariantCultureIgnoreCase));

    public static bool Validate2(string value) => value.ContainsFor(_vaildGreetings);

    private static bool ContainsFor(this string stringVal, string[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            if (stringVal.Contains(values[i], StringComparison.InvariantCultureIgnoreCase))
                return true;
        }
        return false;
    }
    
    public static bool Validate3(string value) => value.ContainsSpan(_vaildGreetings);
    private static bool ContainsSpan(this string stringVal, string[] values)
    {
        var spanValues = values.AsSpan();
        for (int i = 0; i < spanValues.Length; i++)
        {
            if (stringVal.Contains(spanValues[i], StringComparison.InvariantCultureIgnoreCase))
                return true;
        }
        return false;
    }
    
    public static bool Validate4(string value) => Regex.IsMatch(value, "hello|ciao|salut|hallo|hola|ahoj|czesc", RegexOptions.IgnoreCase);

}