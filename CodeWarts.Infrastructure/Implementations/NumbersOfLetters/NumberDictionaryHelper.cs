using System.Collections.Immutable;

namespace CodeWarts.Infrastructure.Implementations.NumbersOfLetters;

public static class NumberDictionaryHelper
{
    private static readonly ImmutableList<NumberDictionaryDto> NumberDictionary = new List<NumberDictionaryDto>()
    {
        NumberDictionaryDto.Create(0, "zero"),
        NumberDictionaryDto.Create(1, "one"),
        NumberDictionaryDto.Create(2, "two"),
        NumberDictionaryDto.Create(3, "three"),
        NumberDictionaryDto.Create(4, "four"),
        NumberDictionaryDto.Create(5, "five"),
        NumberDictionaryDto.Create(6, "six"),
        NumberDictionaryDto.Create(7, "seven"),
        NumberDictionaryDto.Create(8, "eight"),
        NumberDictionaryDto.Create(9, "nine"),
    }.ToImmutableList();

    public static string MapNumber(int number) =>
        number.ToString().Select(x =>
                NumberDictionary.First(y => y.NumberValue == int.Parse(x.ToString())).NumberDescription)
            .Aggregate(string.Empty, (r, c) => r += c);

    public static bool IsEquilibrium(string stringNumber)
    {
        var result = NumberDictionary.FirstOrDefault(x => x.NumberDescription == stringNumber);
        return result != null && result.NumberDescription.Length == result.NumberValue;
    }
}