using System;

class Program
{
    static void Main()
    {
        string num = Console.ReadLine();
        try
        {
            long num2 = long.Parse(num);
            Console.WriteLine($"{num} can fit in:");
            if (num2 >= - 128 && num2 <= 127)
                Console.WriteLine("* sbyte");
            if (num2 >= 0 && num2 <=255)
                Console.WriteLine("* byte");
            if (num2 >= -32768 && num2 <= 32767)
                Console.WriteLine("* short");
            if (num2 >= 0 && num2 <= 65535)
                Console.WriteLine("* ushort");
            if (num2 >= -2147483648 && num2 <= 2147483647)
                Console.WriteLine("* int");
            if (num2 >= 0 && num2 <= 4294967295)
                Console.WriteLine("* uint");
            if (num2 >= -9223372036854775808 && num2 <= 9223372036854775807)
                Console.WriteLine("* long");
        }
        catch(OverflowException e)
        {
            Console.Write(num);
            Console.WriteLine(" can't fit in any type");
        }
    }
}

