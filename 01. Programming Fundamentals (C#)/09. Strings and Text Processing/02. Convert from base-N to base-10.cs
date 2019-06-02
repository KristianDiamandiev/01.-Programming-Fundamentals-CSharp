using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static BigInteger ConvertTo10Base(int baseN, BigInteger number)
    {
        BigInteger convertedNum = 0;
        int exponent = 0;
        while (number > 0)
        {
            convertedNum += number % 10 * BigInteger.Pow(baseN, exponent);
            number = number / 10;
            exponent++;
        }
        return convertedNum;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int baseN = int.Parse(input[0]);
        BigInteger number = BigInteger.Parse(input[1]);
        if (number < 0)
        {
            Console.WriteLine("-" + ConvertTo10Base(baseN, -number));
        }
        else
            Console.WriteLine(ConvertTo10Base(baseN, number));
    }
}
