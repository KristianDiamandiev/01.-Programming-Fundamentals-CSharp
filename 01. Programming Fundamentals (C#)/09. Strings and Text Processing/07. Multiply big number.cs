using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static string Sum(StringBuilder a, StringBuilder b)
    {
        StringBuilder num1 = new StringBuilder();
        StringBuilder num2 = new StringBuilder();
        StringBuilder wholeSum = new StringBuilder();
        string Num1 = a.ToString();
        string Num2 = b.ToString();
        Num1 = Num1.PadLeft(Num2.Length, '0');
        Num2 = Num2.PadLeft(Num1.Length, '0');
        num1.Append(Num1.ToCharArray().Reverse().ToArray());
        num2.Append(Num2.ToCharArray().Reverse().ToArray());
        int sum = 0;
        int reminder = 0;
        for (int i = 0; i < num1.Length - 1; i++)
        {
            sum = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString());
            wholeSum.Append((sum + reminder) % 10);
            reminder = (sum + reminder) / 10;
        }
        sum = int.Parse(num1[num1.Length - 1].ToString()) + int.Parse(num2[num1.Length - 1].ToString()) + reminder;
        wholeSum.Append(sum % 10);
        if (sum / 10 % 10 > 0)
            wholeSum.Append(sum / 10 % 10);
        return (new string(wholeSum.ToString().ToCharArray().Reverse().ToArray()));
    }

    static void Main()
    {
        StringBuilder num1 = new StringBuilder();
        StringBuilder num2 = new StringBuilder();
        StringBuilder wholeSum = new StringBuilder();
        string sum;
        wholeSum.Append(0);
        string Num1 = Console.ReadLine().TrimStart('0');
        string Num2 = Console.ReadLine().TrimStart('0');
        num1.Append(Num1.ToCharArray().Reverse().ToArray());
        num2.Append(Num2.ToCharArray().Reverse().ToArray());
        StringBuilder multiplySum = new StringBuilder();
        for (int i = 0; i < num1.Length; i++)
        {
            for (int j = 0; j < num2.Length; j++)
            {
                multiplySum.Append(int.Parse(num1[i].ToString()) * int.Parse(num2[j].ToString()));
                for (int k = 0; k < i + j; k++)
                    multiplySum.Append(0);
                sum = Sum(wholeSum, multiplySum);
                wholeSum.Clear();
                wholeSum.Append(sum);
                multiplySum.Clear();
            }
        }
        Console.WriteLine(wholeSum);
    }
}
