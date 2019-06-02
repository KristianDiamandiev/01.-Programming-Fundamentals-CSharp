using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());
        int num = (int)(symbol - '0');
        if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            Console.WriteLine("vowel");
        else if (num >= 0 && num <=9)
            Console.WriteLine("digit");
        else
            Console.WriteLine("other");
    }
}

