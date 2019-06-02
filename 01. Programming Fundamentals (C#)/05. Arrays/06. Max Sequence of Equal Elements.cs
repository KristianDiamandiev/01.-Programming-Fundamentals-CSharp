using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] digits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int endPosOfMax = 0;
        int maxCounter = 0;
        int endPos = 0;
        int counter = 1;
        for (int i = 0; i < digits.Length-1; i++)
        {
            if(digits[i] == digits[i+1])
            {
                counter++;
                endPos = i+1;
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

        while (maxCounter > 0)
        {
            Console.Write(digits[endPosOfMax] + " ");
            endPosOfMax--;
            maxCounter--;
        }

    }
}

