using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static BigInteger ConvertToNBase(int baseN, BigInteger number)
    {
        BigInteger multiplyer = 1;
        BigInteger convertedNum = 0;
        while (number > 0)
        {
            convertedNum += number % baseN * multiplyer;
            number = number / baseN;
            multiplyer *= 10;
        }
        return convertedNum;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int baseN = int.Parse(input[0]);
        BigInteger number = BigInteger.Parse(input[1]);

        Console.WriteLine(ConvertToNBase(baseN, number));
    }
}

