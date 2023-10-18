using System.Collections;
using System.Text;

namespace CodeWarts.Infrastructure.Implementations.MinNumFromArray;

public class MinNumFromArray
{
    public static long MinValue(int[] a)
    {
        Array.Sort(a);
        var str = new StringBuilder(a.Length);
        foreach (var num in a.Distinct())
        {
            str.Append(num);
        }

        return long.Parse(str.ToString());
    }
    
    public static long MinValue2(int[] a)
    {
        Array.Sort(a);
        return long.Parse(string.Join(string.Empty, a.Distinct()));
    }
    
    public static long MinValue3(int[] a)
    {
        Array.Sort(a);
        var dict = new Dictionary<int,int>(a.Length);
        foreach (var num in a)
        {
            dict.TryAdd(num,num);
        }

        return long.Parse(string.Join(string.Empty, dict.Select(x=>x.Key)));
    }
}