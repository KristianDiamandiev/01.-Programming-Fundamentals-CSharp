using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
        var Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        var Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        var Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        var rand = new Random();
        int numOfMessages = int.Parse(Console.ReadLine());
        int randomNum;
        for (int i = 0; i < numOfMessages; i++)
        {
            randomNum = rand.Next(0, 6);
            Console.Write(Phrases[randomNum] + " ");
            randomNum = rand.Next(0, 6);
            Console.Write(Events[randomNum] + " ");
            randomNum = rand.Next(0, 8);
            Console.Write(Authors[randomNum] + "-");
            randomNum = rand.Next(0, 5);
            Console.WriteLine(Cities[randomNum]);
        }
    }
}

