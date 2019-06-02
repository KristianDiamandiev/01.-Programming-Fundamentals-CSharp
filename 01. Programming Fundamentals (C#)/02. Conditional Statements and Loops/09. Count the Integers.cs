using System;

class Program
{
    static void Main()
    {
        string input = "1";
        int output, counter = 0;
        while (Int32.TryParse(input, out  output) == true)
        {
            input = Console.ReadLine();
            counter++;
        }
        Console.WriteLine(counter-1);
    }
}