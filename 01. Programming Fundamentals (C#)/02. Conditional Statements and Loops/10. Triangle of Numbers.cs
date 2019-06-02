using System;

class Program
{
    static void Main()
    {
        int counter = 1;
        var num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            while (counter <= i)
            {
                Console.Write(i + " ");
                counter++;
            }
            counter = 1;
            Console.WriteLine();
        }
    }
}

