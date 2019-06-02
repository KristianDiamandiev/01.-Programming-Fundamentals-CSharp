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
        List<int> detonators = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == detonators[0])
            {
                int leftDetonations = detonators[1];
                int rightDetonations = detonators[1];
                while(i - leftDetonations < 0)
                {
                    leftDetonations--;
                }
                while (i + rightDetonations >= numbers.Count)
                {
                    rightDetonations--;
                }
                for (int j = 0; j <= leftDetonations; j++)
                {
                    if (i - detonators[1] < 0)
                        numbers.RemoveAt(0);
                    else if (i - detonators[1] >= numbers.Count)
                        numbers.RemoveAt(numbers.Count - 1);
                    else
                        numbers.RemoveAt(i - detonators[1]);
                }
                for (int j = 0; j < rightDetonations; j++)
                {
                    if (i - detonators[1] < 0)
                        numbers.RemoveAt(0);
                    else if (i - detonators[1] >= numbers.Count)
                        numbers.RemoveAt(numbers.Count - 1);
                    else
                        numbers.RemoveAt(i - detonators[1]);
                }
                if (numbers.Count > 0)
                {
                    i = 0;
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine(numbers.Sum());

    }
}

