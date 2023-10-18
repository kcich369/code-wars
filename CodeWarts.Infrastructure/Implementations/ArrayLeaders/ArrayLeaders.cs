namespace CodeWarts.Infrastructure.Implementations.ArrayLeaders;

public class ArrayLeaders
{
    public static int[] Calculate(int[] numbers)
    {
        var sum = 0;
        var result = new Stack<int>(numbers.Length);
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            var number = numbers[i];
            if (number > sum)
                result.Push(number);
            sum += number;
        }

        return result.ToArray();
    }

    public static int[] Calculate2(int[] numbers)
    {
        var sum = 0;
        var result = new Stack<int>(numbers.Length);
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] > sum)
                result.Push(numbers[i]);
            sum += numbers[i];
        }

        return result.ToArray();
    }
}