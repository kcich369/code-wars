namespace CodeWarts.Infrastructure.Implementations.RowSumOddNumbers;

// 1
// 3     5
// 7     9    11
// 13    15    17    19
// 21    23    25    27    29

//  1  8 27 64  125     2^3  3^3 4^3 5^3

public class RowSumOddNumbers
{
    public static long Calculate(long n)
    {
        return n *n*n;
    }
}