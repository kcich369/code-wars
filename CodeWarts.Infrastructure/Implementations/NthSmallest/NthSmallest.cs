namespace CodeWarts.Infrastructure.Implementations.NthSmallest;

public class NthSmallest
{
    public static int Get(int[] arr, int pos)
    {
        return arr.OrderBy(x => x).ElementAt(pos - 1);
    }
}