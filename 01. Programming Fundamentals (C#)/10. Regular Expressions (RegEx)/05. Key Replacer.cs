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
        //start<213asfaas|end    | or < or \ 
        string keysInput = Console.ReadLine();
        var keys = new char[] { '|', '<', '\\' };
        string start = keysInput.Substring(0, keysInput.IndexOfAny(keys));
        string end = keysInput.Substring(keysInput.LastIndexOfAny(keys) + 1);

        string pattern = $@"{start}.*?{end}";
        string text = Console.ReadLine();
        bool emptyResult = true;
        foreach (Match word in Regex.Matches(text, pattern))
        {
            if ((word.ToString().Substring(start.Length, word.ToString().Length - end.Length - start.Length)).Length > 0)
            {
                emptyResult = false;
            }
            Console.Write(word.ToString().Substring(start.Length, word.ToString().Length - end.Length - start.Length));
        }
        if (emptyResult)
        {
            Console.WriteLine("Empty result");
        }
    }
}

