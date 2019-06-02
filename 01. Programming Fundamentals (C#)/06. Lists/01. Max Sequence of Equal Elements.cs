using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List <int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int counter = 1;
        int maxCounter = 0;
        int value = numbers[0];
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if(numbers[i] == numbers[i+1])
            {
                counter++;
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                value = numbers[i];
            }
            if (numbers[i] != numbers[i+1])
            {
                counter = 1;
            }
        }
        for(int i = 0; i < maxCounter; i++)
        {
            Console.Write(value + " ");
        }
    }
}

