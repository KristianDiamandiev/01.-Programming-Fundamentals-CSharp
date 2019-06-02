using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static string ReverseString(string a)
    {
        char[] reversedString = new char[a.Length];
        int counter = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            reversedString[counter] = a[i];
            counter++;
        }
        return String.Join("", reversedString);
    }

    static void Main()
    {
        List<string> numbers = Console.ReadLine().Split(' ').ToList();
        List<int> numbersInInt = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = ReverseString(numbers[i]);
            numbersInInt.Add(int.Parse(numbers[i]));
        }
        Console.WriteLine(numbersInInt.Sum());
    }
}

