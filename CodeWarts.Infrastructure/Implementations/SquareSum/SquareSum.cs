namespace CodeWarts.Infrastructure.Implementations.SquareSum;

public class SquareSum
{
    public static int Execute(int[] numbers) => ExecuteLinq(numbers);


    private static int ExecuteWithLoop(int[] numbers)
    {
        var result = 0;
        foreach (var number in numbers)
        {
            result += number * number;
        }

        return numbers.Length == 0 ? 0 : result;
    }

    private static int ExecuteLinq(int[] numbers)
    {
        return numbers.Aggregate(0, (total, curr) => (total + curr * curr));
    }
}