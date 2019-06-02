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
        List<int> actions = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> numbers2 = new List<int>();
        for (int i = 0; i < actions[0]; i++)
        {
            numbers2.Add(numbers[i]);
        }

        for (int i = 0; i < actions[1]; i++)
        {
            numbers2.RemoveAt(0);
        }

        if (numbers2.Contains(actions[2]))
        {
            Console.WriteLine("YES!");
        }
        else
            Console.WriteLine("NO!");
    }
}

