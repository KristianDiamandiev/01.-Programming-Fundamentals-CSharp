using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        string pattern = "\\b" + word + "\\b";
        string[] sentences = Console.ReadLine().Split('.', '!', '?');
        foreach(var sentence in sentences)
        {
            if (Regex.IsMatch(sentence, pattern))
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}

