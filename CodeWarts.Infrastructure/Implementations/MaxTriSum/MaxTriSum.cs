namespace CodeWarts.Infrastructure.Implementations.MaxTriSum;

public class MaxTriSum
{
    public static int Calculate(int[] a)
    {
        Array.Sort(a);
        Array.Reverse(a);
        return new HashSet<int>(a).Take(3).Sum();
    }
    
    public static int Calculate2(int[] a)
    {
        return a.Distinct().OrderBy(i => -i).Take(3).Sum();
    }
    
    public static int Calculate3(int[] a)
    {
        return a.Distinct().OrderByDescending(x => x).Take(3).Sum();;
    }
}