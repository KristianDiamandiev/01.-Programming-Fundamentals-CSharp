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
        string[] input = Console.ReadLine().Split(' ');
        int skipNumSymbols = int.Parse(input[0]);
        int takeNumSymbols = int.Parse(input[1]);
        string inputText = Console.ReadLine();
        Regex cameras = new Regex(@"\|\<\w+");

        List<string> camerasInfo = new List<string>();

        foreach (Match match in cameras.Matches(inputText))
        {
            camerasInfo.Add(match.ToString());
        }

        List<string> results = new List<string>();

        foreach (var result in camerasInfo)
        {
            if (result.Substring(skipNumSymbols + 2) != "")
            {
                if (result.Substring(skipNumSymbols + 2).Length > takeNumSymbols)
                    results.Add(result.Substring(skipNumSymbols + 2, takeNumSymbols));
                else
                    results.Add(result.Substring(skipNumSymbols + 2));
            }
        }
        Console.WriteLine(String.Join(", ", results));
    }
}

