namespace CodeWarts.Infrastructure.Implementations.NumbersOfLetters;

public class NumberDictionaryDto
{
    public int NumberValue { get; private set; }
    public string NumberDescription { get; private set; }

    private NumberDictionaryDto(int numberValue, string numberDescription)
    {
        NumberValue = numberValue;
        NumberDescription = numberDescription;
    }

    public static NumberDictionaryDto Create(int numberValue, string numberDescription) =>
        new(numberValue, numberDescription);
}