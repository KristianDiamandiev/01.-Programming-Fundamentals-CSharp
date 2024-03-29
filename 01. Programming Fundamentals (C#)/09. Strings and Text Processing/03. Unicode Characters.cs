using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static string GetUnicodeString(string s)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            sb.Append("\\u");
            sb.Append(String.Format("{0:x4}", (int)c));
        }
        return sb.ToString();
    }

    static void Main()
    {
        string word = Console.ReadLine();
        Console.WriteLine(GetUnicodeString(word));
    }
}

