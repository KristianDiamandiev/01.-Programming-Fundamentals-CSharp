using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<string> input = new List<string> { "NotEvenNotOdd" };
        bool IsOdd;
        while (input[0] != "Even" && input[0] != "Odd")
        {
            input = Console.ReadLine().Split(' ').ToList();
            if (input[0] == "Delete")
            {
                while (numbers.Remove(int.Parse(input[1])) == true)
                {
                    numbers.Remove(int.Parse(input[1]));
                }
            }
            else if (input[0] == "Insert")
            {
                numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
            }
        }
        if (input[0] == "Odd")
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                    Console.Write(numbers[i] + " ");
            }
        }
        else
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.Write(numbers[i] + " ");
            }
        }
    }
}

