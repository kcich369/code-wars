namespace CodeWarts.Infrastructure.Implementations.LongestRepetition;

public static class LongestRepetition
{
    // public static Tuple<char?, int> Execute(string input)
    // {
    //     var a = input.GroupBy(x => x);
    //     if (!a.Any())
    //         return new Tuple<char?, int>(null, 0);
    //     var b = a.MaxBy(x => x.Count());
    //     return new Tuple<char?, int>(b.Key, b.Count());
    // }

    public static Tuple<char?, int> Execute(string input)
    {
        var results = new List<Repetition>();
        var counter = 0;
        var character = input[0];
        foreach (var sign in input)
        {
            if (character != sign)
            {
                counter++;
                continue;
            }
            results.Add(new Repetition(sign, counter));
            character = sign;
            counter = 0;
        }

        var a = results.MaxBy(x => x.Count);
        return new Tuple<char?, int>(a.Character, a.Count);
    }

    private record Repetition(char Character, int Count);
}