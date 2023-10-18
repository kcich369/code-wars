namespace CodeWarts.Infrastructure.Implementations.AdjacentElementsProduct;

public class AdjacentElementsProduct
{
    public static int Product(int[] array)
    {
        var sums = new int[array.Length - 1];
        for (var i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
                continue;
            sums[i] = array[i] * array[i + 1];
        }

        return sums.MaxBy(x=>x);
    }
    
    public static int Product2(int[] array)
    {
        return array.Skip(1).Select((x,i) => x * array[i]).Max();
    }
    
    public static int Product3(int[] array)
    {
       return array.Skip(1).Zip(array, (x, y) => x * y).Max();
    }
}