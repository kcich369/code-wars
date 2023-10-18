namespace CodeWarts.Infrastructure.Implementations.MinSum;

public class MinSum
{
    public static int Get1(int[] a)
    {
        return a.OrderBy(n => n).Skip(a.Length / 2).Zip(a.OrderByDescending(n => n).Skip(a.Length / 2), (x, y) => x * y)
            .Sum();
    }

    public static int Get(int[] a)
    {
        return a.OrderBy(x=>x).Take(0..(a.Length / 2)).Zip(a.OrderByDescending(x=>x).Take(0..(a.Length / 2)), (a1, a2) => a1 * a2).Sum();
    }
    
    public static int Get2(int[] a)
    {
        var dvd = a.Length / 2;
        var sortedList = a.OrderByDescending(x => x).ToList();
        var r2 = sortedList.Take(0..dvd).Zip(sortedList.Take(dvd..).OrderBy(x => x), (a1, a2) => a1 * a2).Sum();
        var r1 = sortedList.Take(0..dvd).Zip(sortedList.Take(dvd..), (a1, a2) => a1 * a2).Sum();
        return r1 < r2 ? r1 : r2;
    }
}