using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        string word1 = input[0];
        string word2 = input[1];
        word1 = new String(word1.Distinct().ToArray());
        word2 = new String(word2.Distinct().ToArray());
        if (word1.Length == word2.Length)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}

