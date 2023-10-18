namespace CodeWarts.Infrastructure.Implementations.AlphabeticalAddition;

public class AlphabeticalAddition
{
    //TODO: THE BEST RESULT
    //var val = letters.Sum(c => c-96) % 26;
    //return val == 0 ? 'z' : (char)(val + 96);
    public static char AddLetters(char[] letters)
    {
        return !letters.Any() ? 'z' : (char)(letters.Sum(letter => (int)letter - 96) % 26 + 96);
    }
}