namespace CodeWarts.Infrastructure.Implementations.SimpleStringCharacters;

public static class SimpleStringCharacters
{
    public static int[] Solve(String s)
    {
            int uppercase = 0, lowercase = 0, numbers = 0, specials = 0;
            foreach (var ch in s)
            {
                if (ch >= 33 && ch <= 47
                    || ch >= 58 && ch <= 64
                    || ch >= 155 && ch <= 160
                    || ch >= 187 && ch <= 190)
                    specials++;
                if (ch >= 48 && ch <= 57)
                    numbers++;
                if (ch >= 97 && ch <= 122)
                    lowercase++;
                if (ch >= 65 && ch <= 90)
                    uppercase++;
            }

            return new[] { uppercase, lowercase, numbers, specials };
    }
}