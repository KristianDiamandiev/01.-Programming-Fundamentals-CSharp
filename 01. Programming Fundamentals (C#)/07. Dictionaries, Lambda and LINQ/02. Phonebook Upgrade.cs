using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var phonebook = new SortedDictionary<string, string>();
        string[] input = new string[10000];
        for (int i = 0; i < input.Length; i++)
            Console.Write(input[i] + " ");
        while (input[input.Length - 1] != "END")
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
            else if (input [0] == "ListAll")
            {
                foreach (var item in phonebook)
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
            }
        }
    }
}
