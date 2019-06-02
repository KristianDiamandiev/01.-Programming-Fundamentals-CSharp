using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var digits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] part1 = new int[digits.Length / 4];
        int counter = 0;
        for (int i = (digits.Length / 4) - 1; i >= 0; i--)
        {
            part1[counter] = digits[i];
            counter++;
        }

        int[] part2 = new int[digits.Length / 2];
        int inputIndex = 0;
        for (int i = counter; i < (digits.Length / 2 + digits.Length / 4); i++)
        {
            part2[inputIndex] = digits[i];
            inputIndex++;
            counter++;
        }

        inputIndex = 0;
        int[] part3 = new int[digits.Length / 4];
        for (int i = digits.Length - 1; i >= counter; i--)
        {
            part3[inputIndex] = digits[i];
            inputIndex++;
        }

      /*Console.Write(String.Join(" ", part1));
        Console.WriteLine(" " + String.Join(" ", part3));
        Console.WriteLine(String.Join(" ", part2));*/

        for (int i = 0; i < part1.Length; i++)
            Console.Write(part1[i] + part2[i] + " ");
        for (int i = 0; i < part3.Length; i++)
            Console.Write(part3[i] + part2[i + digits.Length / 4] + " ");
    }
}

