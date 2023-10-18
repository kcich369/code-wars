namespace CodeWarts.Infrastructure.Implementations.NumbersOfLetters;

public static class NumbersOfLetters
{
    public static string[] Execute(int number)
    {
        var results = new List<string>();
        var a = NumberDictionaryHelper.IsEquilibrium;
        var stringNumber = NumberDictionaryHelper.MapNumber(number);
        do
        {
            var result = NumberDictionaryHelper.MapNumber(stringNumber.Length);
            results.Add(stringNumber);
            stringNumber = result;
        } while (!NumberDictionaryHelper.IsEquilibrium(stringNumber));
        results.Add(stringNumber);
        return results.ToArray();
    }
}