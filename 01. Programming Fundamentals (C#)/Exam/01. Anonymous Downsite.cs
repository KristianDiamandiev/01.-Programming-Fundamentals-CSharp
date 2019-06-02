using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        decimal N = decimal.Parse(Console.ReadLine());
        BigInteger token = BigInteger.Parse(Console.ReadLine());

        List<string> sites = new List<string>();
        string[] input = new string[3];
        decimal sum = 0;
        for (decimal i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split().ToArray();
            sites.Add(input[0]);
            sum += (decimal.Parse(input[1])) * (decimal.Parse(input[2]));
        }
        if (N == 0)
        {
            Console.WriteLine("Total Loss: {0:F20}", 0);
            Console.WriteLine("Security Token: {0}", 0);
        }
        else
        {
            Console.Write(String.Join("\r\n", sites));
            Console.WriteLine("\r\nTotal Loss: {0:F20}", sum);
            BigInteger token2 = token;
            for (decimal i = 0; i < sites.Count-1; i++)
            {
                token2 *= token;
            }
            Console.WriteLine("Security Token: {0}", token2);
        }
    }
}

