using System.Text;

namespace CodeWarts.Infrastructure.Implementations.PigIt;

public class PigIt
{
    public static string Process(string str)
    {
        var resultBuilder = new StringBuilder();
        foreach (var word in str.Split())
        {
            resultBuilder.Append($"{word.Remove(0, 1)}{word[0]}ay ");
        }

        return resultBuilder.ToString().Remove(resultBuilder.Length-1);
    }

    public static string Process2(string str)
    {
        return string.Join(" ", str.Split().Select(x => $"{x.Remove(0, 1)}{x[0]}ay"));
    }
}