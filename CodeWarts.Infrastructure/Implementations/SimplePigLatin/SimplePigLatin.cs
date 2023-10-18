namespace CodeWarts.Infrastructure.Implementations.SimplePigLatin;

public class SimplePigLatin
{
    public static string PigIt(string str)
    {
        var splitted = str.Split().Select(x=>x);
        return str;
    }
}