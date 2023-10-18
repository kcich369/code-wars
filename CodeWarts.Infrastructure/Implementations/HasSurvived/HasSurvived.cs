namespace CodeWarts.Infrastructure.Implementations.HasSurvived;

public class HasSurvived
{
    public static bool Process(int[] attackers, int[] defenders)
    {
        var wins = attackers.Zip(defenders, (a, d) => a < d).Count(x => x);
        var result = attackers.Length - wins;
        if (result == wins)
            return defenders.Sum() >= attackers.Sum();
        return wins > attackers.Length - wins;
    }
}