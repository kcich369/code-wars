namespace CodeWarts.Infrastructure.Implementations.ToCamelCase;

public static class ToCamelCase
{
    public static string Execute2(string str)
    {
        str = str.Replace('-', '_');
        var isSign = false;
        var result = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            var r = str[i];
            if (isSign)
            {
                isSign = false;
                r = char.ToUpper(str[i]);
            }

            if (str[i] == '_')
                isSign = true;
            result[i] = r;
        }

        return new string(result).Replace("_", string.Empty);
    }

    public static string Execute(string input)
    {
        input = input.Replace('-', '_');
        return ToUpperCaseByIndexes(input.ToArray(), input.AllIndexesOf());
    }
    
    private static string ToUpperCaseByIndexes(this char[] strArr, IEnumerable<int> indexes)
    {
        foreach (var index in indexes)
        {
            strArr[index + 1] = char.ToUpper(strArr[index +1]);
        }

        return new string(strArr).Replace("_","");
    }

    private static IEnumerable<int> AllIndexesOf(this string str)
    {
        int minIndex = str.IndexOf('_');
        while (minIndex != -1)
        {
            yield return minIndex;
            minIndex = str.IndexOf('_', minIndex + 1);
        }
    }
}