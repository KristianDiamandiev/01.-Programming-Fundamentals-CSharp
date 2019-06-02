using System;

class Program
{
    static void Main()
    {
        var proffesion = Console.ReadLine();
        var amount = int.Parse(Console.ReadLine());
        if(proffesion == "Athlete")
            Console.WriteLine("The Athlete has to pay {0:F2}.", amount*0.70);
        else if (proffesion == "Businessman")
            Console.WriteLine("The Businessman has to pay {0:F2}.", amount*1.00);
        else if (proffesion  == "Businesswoman")
            Console.WriteLine("The Businesswoman has to pay {0:F2}.", amount * 1.00);
        else if (proffesion == "SoftUni Student")
            Console.WriteLine("The SoftUni Student has to pay {0:F2}.", amount * 1.70);
        else
            Console.WriteLine("The {0} has to pay {1:F2}.", proffesion, amount*1.20);
    }
}
