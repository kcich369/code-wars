namespace CodeWarts.Infrastructure.Implementations.SpacesRemover;

public static class SpacesRemover
{
    public static string NoSpace(string input) => input.Replace(" ", string.Empty);
}