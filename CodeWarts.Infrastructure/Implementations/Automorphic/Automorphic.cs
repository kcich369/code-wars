namespace CodeWarts.Infrastructure.Implementations.Automorphic;

public class Automorphic
{
    public static string Calculate(int n)
    {
        return int.Parse($"{n * n}"[($"{n * n}".Length-$"{n}".Length)..]) == n ? "Automorphic" : "Not!!";
    }
}