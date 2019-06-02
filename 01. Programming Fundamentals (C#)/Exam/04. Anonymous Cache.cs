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
        Dictionary<string, List<string>> dataSets = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> cache = new Dictionary<string, List<string>>();
        List<string> input = Console.ReadLine().Split('|').ToList();
        while(input[0] != "thetinggoesskrra")
        {
            if (input.Count == 1)
            {
                dataSets.Add(input[0], new List<string>());
            }
            if (input.Count == 2)
            {
                string dataAndSize = input[0].Trim();
                string dataKey = input[1].Trim();
                if (dataSets.ContainsKey(dataKey))
                {
                    dataSets[dataKey].Add(dataAndSize);
                }
                else
                {
                    if (!cache.ContainsKey(dataKey))
                    {
                        cache[dataKey] = new List<string>();
                        cache[dataKey].Add(dataAndSize);
                    }
                    else
                        cache[dataKey].Add(dataAndSize);
                }
            }
            input = Console.ReadLine().Split('|').ToList();
        }
        foreach (var set in cache)
        {
            if (dataSets.ContainsKey(set.Key))
            {
                for (int i = 0; i < set.Value.Count; i++)
                {
                    dataSets[set.Key].Add(set.Value[i]);
                }
            }
        }

        BigInteger maxValue = 0;
        string maxKey = "";
        foreach (var set in dataSets)
        {
            BigInteger setValue = 0;
            for (int i = 0; i < set.Value.Count; i++)
            {
                setValue += BigInteger.Parse(set.Value[i].Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)[1]);
            }
            if (maxValue < setValue)
            {
                maxValue = setValue;
                maxKey = set.Key;
            }
        }
        if (maxKey != "")
        {
            Console.WriteLine("Data Set: {0}, Total Size: {1}", maxKey, maxValue);
            Console.Write("$.");
            List<string> keysOnly = new List<string>();
            string currentKey = "";
            for (int i = 0; i < dataSets[maxKey].Count; i++)
            {
                currentKey = dataSets[maxKey][i];
                keysOnly.Add(currentKey.Split()[0]);
            }
            Console.WriteLine(String.Join("\r\n$.", keysOnly));
        }
    }
}

