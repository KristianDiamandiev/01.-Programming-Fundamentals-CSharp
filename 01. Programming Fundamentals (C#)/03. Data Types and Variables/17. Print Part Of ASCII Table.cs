using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        char Symbol1 = (char)int.Parse(Console.ReadLine());
        char Symbol2 = (char)int.Parse(Console.ReadLine());
        while(Symbol1 != Symbol2+1)
        {
            Console.Write(Symbol1 + " ");
            Symbol1++;
        }
    }
}

