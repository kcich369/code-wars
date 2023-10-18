namespace CodeWarts.Infrastructure.Implementations.ProductArray;

public class ProductArray
{
    public static int[] Get(int[] array)
    {
        var product = array.Aggregate((x, y) => x * y);
        return array.Select(t => product / t).ToArray();
    }
}