using System;
using System.Linq;

class Program
{
    static void Main()
    {
        long[] digits = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long endPosOfMax = 0;
        long maxCounter = 0;
        long endPos = 0;
        long counter = 1;
        for (long i = 0; i < digits.Length - 1; i++)
        {
            if (digits[i] < digits[i + 1])
            {
                counter++;
                endPos = i + 1;
            }
            else
            {
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    endPosOfMax = endPos;
                }
                counter = 1;
            }
        }

        if (counter > maxCounter)
        {
            maxCounter = counter;
            endPosOfMax = endPos;
        }

        long[] digits2 = new long[digits.Length];
        long inputIndex = 0;
        long maxCounter2 = maxCounter;
        while (maxCounter > 0)
        {
            digits2[inputIndex] = digits[endPosOfMax];
            endPosOfMax--;
            maxCounter--;
            inputIndex++;
        }

        for (long i = maxCounter2-1; i >= 0; i--)
            Console.Write(digits2[i] + " ");
    }
}
