using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
            for (int j = 0; j < letters.Length; j++)
            {
                if (input[i] == letters[j])
                    Console.WriteLine(letters[j] + " -> " + j);
            }
    }
}

