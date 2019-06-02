using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] charArr1 = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
        char[] charArr2 = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
        int minLength = Math.Min(charArr1.Length, charArr2.Length);
        bool printed = false;
        for (int i = 0; i < minLength; i++)
        {
            if (charArr1[i] < charArr2[i])
            {
                Console.WriteLine(String.Join("",charArr1));
                Console.WriteLine(String.Join("", charArr2));
                printed = true;
                break;
            }
            else if (charArr1[i] > charArr2[i])
            {
                Console.WriteLine(String.Join("", charArr2));
                Console.WriteLine(String.Join("", charArr1));
                printed = true;
                break;
            }
        }
        if (printed == false)
        {
            if(charArr1.Length < charArr2.Length)
            {
                Console.WriteLine(String.Join("", charArr1));
                Console.WriteLine(String.Join("", charArr2));
            }
            else
            {
                Console.WriteLine(String.Join("", charArr2));
                Console.WriteLine(String.Join("", charArr1));
            }
        }
    }
}

