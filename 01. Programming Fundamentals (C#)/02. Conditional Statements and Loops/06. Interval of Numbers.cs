using System;

class Program
{
    static void Main()
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        if (num2 >= num1)
            for(int i = num1; i <=num2; i++)
                Console.WriteLine(i);
        else
            for (int i = num2; i <= num1; i++)
                Console.WriteLine(i);
    }
}

