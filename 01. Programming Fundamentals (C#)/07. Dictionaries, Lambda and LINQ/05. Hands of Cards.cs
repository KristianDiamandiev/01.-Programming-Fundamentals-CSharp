using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int ConvertCardToValue(string num, char letter)
    {
        string[] values = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char[] paint = { 'C' , 'D', 'H', 'S'};
        int sum = 0;
        for (int i = 0; i < 15; i++)
        {
            if (num == values[i])
            {
                sum += i;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (letter == paint[i])
            {
                sum *= (i + 1);
            }
        }
        return sum;
    }

    static void Main()
    {
        var input = new List<string>();
        var personsCards = new Dictionary<string, List<string>>();
        string[] wholeInput = Console.ReadLine().Split(':').ToArray();
        if (wholeInput.Length != 1)
        {
            string name = wholeInput[0];
            input = wholeInput[1].Replace(",", "").Split(' ').ToList();

            while (input[0] != "JOKER")
            {
                if (!personsCards.ContainsKey(name))
                {
                    personsCards.Add(name, new List<string>());
                }
                for (int i = 1; i < input.Count(); i++)
                {
                    if (!personsCards[name].Contains(input[i]))
                    {
                        personsCards[name].Add(input[i]);
                    }
                }

                wholeInput = Console.ReadLine().Split(':').ToArray();
                if (wholeInput.Length == 1)
                    break;
                name = wholeInput[0];
                input = wholeInput[1].Replace(",", "").Split(' ').ToList();
            }
        }

        foreach (var item in personsCards)
        {
            int sum = 0;
            Console.Write(item.Key + ": ");
            foreach (string card in item.Value)
            {
                string power = card.Remove(card.Length - 1);
                char paint = card[card.Length-1];
                sum += ConvertCardToValue(power, paint);
            }
            Console.WriteLine(sum);
        }
    }
}

