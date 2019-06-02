using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int SumOfMultipliedLetters(string a, string b)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i] * b[i];
        }
        for (int i = a.Length; i < b.Length; i++)
        {
            sum += b[i];
        }
        return sum;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        string word1 = input[0];
        string word2 = input[1];
        if (word1.Length <= word2.Length)
        {
            Console.WriteLine(SumOfMultipliedLetters(word1, word2));
        }
        else
        {
            Console.WriteLine(SumOfMultipliedLetters(word2, word1));
        }
    }
}

