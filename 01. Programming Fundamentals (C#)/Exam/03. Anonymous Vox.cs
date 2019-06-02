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
        string pattern = @"([a-zA-Z]+)(?=.+\1)";
        string input = Console.ReadLine();
        int k = 0;
        int l = 0;
        List<string> changeWords = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        if ((changeWords.Count == 0 || Regex.Matches(input, pattern).Count == 0) && input != "")
            Console.WriteLine(input);
        else
        {
            while (k < changeWords.Count && l < Regex.Matches(input, pattern).Count)
            {
                StringBuilder output = new StringBuilder("");
                Match m = Regex.Match(input, pattern);
                output.Append(input.Substring(0, m.Index - 0));
                output.Append(m.Value);
                output.Append(changeWords[k]);
                k++;
                output.Append(m.Value);
                Console.Write(output);
                int afterIndex = input.LastIndexOf(m.Value) + m.Value.Length;
                output = new StringBuilder(input.Substring(afterIndex));
                input = output.ToString();
                l++;
            }
        }
        Console.Write(input);
    }
}

