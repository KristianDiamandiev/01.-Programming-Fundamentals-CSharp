using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var phonebook = new Dictionary<string, string>();
        string[] input = new string[10000];
        while (input[input.Length-1] != "END")
        {
            input = Console.ReadLine().Split(' ');
            if (input[0] == "A")
            {
                if (phonebook.ContainsKey(input[1]))
                {
                    phonebook[input[1]] = input[2];
                }
                else
                    phonebook.Add(input[1], input[2]);
            }
            else if (input[0] == "S")
            {
                if (phonebook.ContainsKey(input[1]))
                    Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                else
                    Console.WriteLine("Contact {0} does not exist.", input[1]);
            }
        }
    }
}
