namespace CodeWarts.Infrastructure.Implementations;

public static class DeadFish
{
    public static int[] Parse(string data)
    {
        var results = new int[data.Count(x => x == 'o')];
        var number = 0;
        var counter = 0;

        foreach (var letter in data)
        {
            switch (letter)
            {
                case 'o':
                    results[counter] = number;
                    counter++;
                    break;
                case 'i':
                    number += 1;
                    break;
                case 'd':
                    number -= 1;
                    break;
                case 's':
                    number *= number;
                    break;
            }
        }

        return results;
    }

    public static int[] ParseDictionary(string data)
    {
        var values = new List<int>(0);
        var dictActions = new Dictionary<char, Func<int, int>>()
        {
            { 'i', x => x + 1 },
            { 'd', x => x - 1 },
            { 's', x => x * x },
            { 'o', x => { values.Add(x); return x; }}
        };
          data
            .ToCharArray()
            .Where(item => dictActions.ContainsKey(item))
            .Aggregate(0, (current, item) => dictActions[item](current));

        return values.ToArray();
    }

    public static int[] ParseList(string data)
    {
        var results = new List<int>(0);
        var number = 0;
        foreach (var letter in data)
        {
            switch (letter)
            {
                case 'o':
                    results.Add(number);
                    break;
                case 'i':
                    number += 1;
                    break;
                case 'd':
                    number -= 1;
                    break;
                case 's':
                    number *= number;
                    break;
            }
        }
        return results.ToArray();
    }
}