namespace CodeWarts.Infrastructure.Implementations.MaxProduct;

public class MaxProduct
{
    public static int Get(int[] arr, int size)
    {
        return arr.OrderByDescending(x => x).Take(size).Aggregate((x, y) => x * y);
    }
}