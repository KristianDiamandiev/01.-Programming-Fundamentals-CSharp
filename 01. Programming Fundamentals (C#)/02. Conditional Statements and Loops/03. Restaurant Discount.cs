using System;

class Program
{
    static void Main()
    {
        var numOfPeople = int.Parse(Console.ReadLine());
        var package = Console.ReadLine();
        var totalPrice = 0.0;
        if (numOfPeople <= 50)
        {
            Console.WriteLine("We can offer you the Small Hall");
            totalPrice = 2500;
        }
        else if (numOfPeople <= 100)
        {
            Console.WriteLine("We can offer you the Terrace");
            totalPrice = 5000;
        }
        else if (numOfPeople <= 120)
        {
            Console.WriteLine("We can offer you the Great Hall");
            totalPrice = 7500;
        }
        else
            Console.WriteLine("We do not have an appropriate hall.");

        if (numOfPeople <= 120)
        {
            if (package == "Normal")
                Console.WriteLine("The price per person is {0:F2}$", ((totalPrice + 500) * 0.95)/numOfPeople);
            else if (package == "Gold")
                Console.WriteLine("The price per person is {0:F2}$", ((totalPrice + 750) * 0.90)/numOfPeople);
            else
                Console.WriteLine("The price per person is {0:F2}$", ((totalPrice + 1000) * 0.85)/numOfPeople);
        }
    }
}