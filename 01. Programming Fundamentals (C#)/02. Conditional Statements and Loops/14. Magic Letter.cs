using System;

class Program
{
    static void Main()
    {
        var letter1 = char.Parse(Console.ReadLine());
        var letter2 = char.Parse(Console.ReadLine());
        var forbidenLet = char.Parse(Console.ReadLine());
        for (char i = letter1; i <= letter2; i++)
            for (char j = letter1; j <= letter2; j++)
                for (char k = letter1; k <= letter2; k++)
                {
                    if (i != forbidenLet && j != forbidenLet && k != forbidenLet)
                        Console.Write("{0}{1}{2} ", i, j, k);
                }
        Console.WriteLine();
    }   
}

