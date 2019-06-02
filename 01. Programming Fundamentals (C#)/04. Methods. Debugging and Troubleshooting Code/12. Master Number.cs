using System;

class Program
{
    static bool IsSymmetric (long a)
    {
        if (a < 10)
            return true;
        else
        {
            string numInString = a.ToString();
            for (int i = 0; i < numInString.Length/2; i++)
            {
                if (numInString[i] != numInString[numInString.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }

    static bool IsSumOfDigitsDivisibleBy7 (long a)
    {
        int sum = 0;
        while (a > 0)
        {
            sum = sum + (int)(a % 10);
            a = a / 10;
        }
        if (sum % 7 == 0)
            return true;
        else
            return false;
    }

    static bool NumberContainsEvenDigit (long a)
    {
        while (a > 0)
        {
            if (a % 2 == 0)
                return true;
            a = a / 10;
        }
        return false;
    }

    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        for (long i = 232; i <= num; i++)
        {
            if (IsSymmetric(i) == true && IsSumOfDigitsDivisibleBy7(i) == true && NumberContainsEvenDigit(i) == true)
                Console.WriteLine(i);
        }
    }
}

