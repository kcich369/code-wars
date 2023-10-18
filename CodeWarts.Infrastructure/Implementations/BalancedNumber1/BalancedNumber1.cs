namespace CodeWarts.Infrastructure.Implementations.BalancedNumber1;

public static class BalancedNumber1
{
    public static string BalancedNumber(int number)
    {
        if (number < 100)
            return "Balanced";
        var numS = number.ToString();
        var roundUp = (int)Math.Ceiling((decimal)numS.Length / 2);
        return numS.Take(roundUp - 1).Sum(x => x) ==
               numS.Skip(numS.Length % 2 == 0 ? ++roundUp : roundUp).Sum(x => x)
            ? "Balanced"
            : "Not Balanced";
    }

    public static string BalancedNumber2(int number)
    {
        if (number < 100)
            return "Balanced";
        var numberS = number.ToString();
        var middleIndx = (numberS.Length / 2);
        var left = new HashSet<int>(middleIndx);
        var right = new HashSet<int>(middleIndx);
        var leftSum = 0;
        var rightSum = 0;
        var isEventL = numberS.Length % 2 == 0;
        if (isEventL)
        {
            middleIndx--;
            for (int i = 0; i < numberS.Length; i++)
            {
                if (i < middleIndx)
                    left.Add(numberS[i] - '0');
                if (i > middleIndx + 1)
                    right.Add(numberS[i] - '0');
            }
        }
        else
        {
            for (int i = 0; i < numberS.Length; i++)
            {
                if (i < middleIndx)
                    left.Add(numberS[i] - '0');
                if (i > middleIndx)
                    right.Add(numberS[i] - '0');
            }
        }


        return left.Sum() == right.Sum()
            ? "Balanced"
            : "Not Balanced";
    }
    
    public static string BalancedNumber2Sum(int number)
    {
        if (number < 100)
            return "Balanced";
        var numberS = number.ToString();
        return IsSumEqual(number.ToString());
    }

    private static string IsSumEqual(string numberS)
    {
        var leftSum = 0;
        var rightSum = 0;
        var middleIndx = (numberS.Length / 2);
        var middleIndxLeft = middleIndx;
        if (numberS.Length % 2 == 0)
        {
            middleIndxLeft--;
        }
        for (int i = 0; i < numberS.Length; i++)
        {
            if (i < middleIndxLeft)
                leftSum += numberS[i] - '0';
            if (i > middleIndx)
                rightSum +=numberS[i] - '0';
        }
        
        return leftSum == rightSum
            ? "Balanced"
            : "Not Balanced";
    }

    public static string BalancedNumberBest1(int number)
    {
        double middle = number.ToString().Length / 2.0;
        var leftSum = number.ToString().Take((int)Math.Ceiling(middle - 1)).Sum(x => x);
        var rightSum = number.ToString().Skip((int)++middle).Sum(x => x);
        return leftSum == rightSum ? "Balanced" : "Not Balanced";
    }

    public static string BalancedNumberBest2(int number)
    {
        return $"{number}".Take(($"{number}".Length + 1) / 2 - 1).Sum(c => c) ==
               $"{number}".Skip($"{number}".Length / 2 + 1).Sum(c => c)
            ? "Balanced"
            : "Not Balanced";
    }

    static void ArrayFüllung(ref int[] array, string zahlen)
    {
        for (int i = 0; i < zahlen.Length; i++)
        {
            array[i] = zahlen[i];
        }
    }

    public static string BalancedNumberOther1(int number)
    {
        //Do Some Magic
        string numb = Convert.ToString(number);
        int mid = numb.Length / 2;
        string rechts = numb.Substring(mid + 1);
        int länge = rechts.Length;
        int[] arr = new int[länge];
        int[] arl = new int[länge];
        ArrayFüllung(ref arr, rechts);
        if (numb.Length % 2 == 1) numb = numb.Remove(mid);
        else numb = numb.Remove(mid - 1);
        ArrayFüllung(ref arl, numb);
        int R = arr.Sum();
        int L = arl.Sum();
        if (R == L) return "Balanced";
        else return "Not Balanced";
    }

    public static string BalancedNumberOther2(int number)
    {
        int count_digit = 1;
        int _temp_number = number;
        for (int i = 1;; i++)
        {
            if (_temp_number / 10 == 0)
            {
                count_digit = i;
                break;
            }
            else
            {
                _temp_number /= 10;
                continue;
            }
        }

        if (count_digit <= 2)
        {
            return "Balanced";
        }

        int[] digits = new int[50];
        _temp_number = number;
        for (int i = 0; i < count_digit; i++)
        {
            digits[i] = _temp_number % 10;
            _temp_number /= 10;
        }

        int len_seg = (count_digit - 2) / 2;
        if (count_digit % 2 == 1)
        {
            len_seg = (count_digit - 1) / 2;
        }

        int Sum_left = 0;
        int Sum_right = 0;
        for (int i = 0; i < count_digit; i++)
        {
            if (i < len_seg)
            {
                Sum_left += digits[i];
            }

            if (i >= (count_digit - len_seg))
            {
                Sum_right += digits[i];
            }
        }

        if (Sum_right == Sum_left)
        {
            return "Balanced";
        }

        return "Not Balanced";
    }
}