using System;

class Program
{
    static void IsPrime(long n)
    {
        if (n == 0 || n == 1)
        {
            Console.WriteLine("False");
        }
        else if (n == 2 || n == 3)
        {
            Console.WriteLine("True");
        }
        else
        {
            for (long i = 2; i <= (long)Math.Sqrt(n) + 1; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("False");
                    return;
                }
            }
            Console.WriteLine("True");
        }
    }

    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        IsPrime(num);
    }
}

