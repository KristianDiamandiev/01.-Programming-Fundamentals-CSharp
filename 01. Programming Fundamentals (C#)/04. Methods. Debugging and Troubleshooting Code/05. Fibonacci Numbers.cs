using System;

class Program
{
    static void Fib(int n)
    {
        int num1 = 1;
        int num2 = 1;
        if (n <= 1)
        {
            Console.WriteLine(num1);
        }
        else
        {
            int counter = 2;
            while(counter <= n)
            {
                int num3 = num1;
                num1 = num1 + num2;
                num2 = num3;
                counter++;
            }
            Console.WriteLine(num1);
        }
    }

    static void Main()
    {
            int num = int.Parse(Console.ReadLine());
            Fib(num);
    }
}

