namespace CodeWarts.Infrastructure.Implementations;

public class SpecialNumber
{
    public static string IsSpecialNumber(int number)
    {
        return number.ToString().All(x => x-'0' < 6) ? "Special!!" : "NOT!!";
        // return "NOT!!";
        // // return "Special!!"
    }
}