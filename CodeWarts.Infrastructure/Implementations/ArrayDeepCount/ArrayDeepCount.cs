namespace CodeWarts.Infrastructure.Implementations.ArrayDeepCount;

public static class ArrayDeepCount
{
    public static int Count(object a)
    {
        var array = a as Array;
        return array.Length + array.OfType<Array>().Sum(Count);
    }
}