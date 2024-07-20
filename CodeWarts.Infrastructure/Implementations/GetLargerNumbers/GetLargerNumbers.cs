namespace CodeWarts.Infrastructure.Implementations.GetLargerNumbers;

public static class GetLargerNumbers
{
    public static int [] Execute(int [] a , int [] b)
    {
       return a.Select((el, i) => el > b[i] ? el : b[i]).ToArray();
    }
    
    public static int [] Execute2(int [] a , int [] b)
    {
        return a.Zip(b,(x,y)=> x > y ? x : y).ToArray();
    }
}