using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        BigInteger num = 1;
        for (long i = 1; i <= a; i++)
            num = num * i;
        string numInString = num.ToString();
        int length = numInString.Length-1;
        int counter = 0;
        while(0==0)
        {
            if (numInString[length] == '0')
            {
                counter++;
                length--;
            }
            else
                break;
        }
        Console.WriteLine(counter);
    }
}

