using System;

class Program
{
    static void Main()
    {
        var noun = Console.ReadLine();
        var length = noun.Length;
        if (noun.EndsWith("y") == true)
            Console.WriteLine(noun.Remove(length-1) + "ies");
        else if (noun.EndsWith("o") == true || noun.EndsWith("ch") == true || noun.EndsWith("s") == true || noun.EndsWith("sh") == true || noun.EndsWith("x") == true || noun.EndsWith("z") == true)
            Console.WriteLine(noun + "es");
        else
            Console.WriteLine(noun + "s");
    }
}
