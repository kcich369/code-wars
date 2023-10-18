namespace CodeWarts.Infrastructure.Implementations.NextHappyYear;

public static class NextHappyYear
{
    public static short Get(short year)
    {
        do
        {
            year++;
        } while (year.ToString().Distinct().Count() != 4);

        return year;
    }
}