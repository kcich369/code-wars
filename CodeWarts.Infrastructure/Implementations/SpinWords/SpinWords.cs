using System.Runtime.InteropServices;
using System.Text;

namespace CodeWarts.Infrastructure.Implementations.SpinWords;

public class SpinWords
{
    public static string Revers(string sentence)
    {
        var splitted = sentence.Split();
        var newString = new StringBuilder();
        for (int i = 0; i < splitted.Length; i++)
        {
            var word = newString.Append(splitted[i].Length >= 5
                ? new string(splitted[i].Reverse().ToArray())
                : splitted[i]);
            if (splitted.Length > 1 && i < splitted.Length - 1)
                newString.Append(' ');
        }

        return newString.ToString();
    }

    public static string ReversSpan(string sentence)
    {
        var splitted = new Span<string>(sentence.Split());
        var newString = new StringBuilder();
        for (int i = 0; i < splitted.Length; i++)
        {
            var a = splitted[i];
            var word = newString.Append(splitted[i].Length >= 5
                ? new string(splitted[i].Reverse().ToArray())
                : splitted[i]);
            if (splitted.Length > 1 && i < splitted.Length - 1)
                newString.Append(' ');
        }

        return newString.ToString();
    }
    
    public static string Revers2(string sentence)
    {
        return string.Join(' ', sentence.Split().Select(x => x.Length >= 5 ? new string(x.Reverse().ToArray()) : x));
    }
}