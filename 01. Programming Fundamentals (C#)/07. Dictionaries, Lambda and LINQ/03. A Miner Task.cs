using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var resources = new Dictionary<string, int>();
        string inputResource = null;
        int inputValue;
        while (0 == 0)
        {
            inputResource = Console.ReadLine();
            if (inputResource == "stop")
            {
                break;
            }

            inputValue = int.Parse(Console.ReadLine());
            if (resources.ContainsKey(inputResource))
            {
                resources[inputResource] += inputValue;
            }
            else
            {
                resources.Add(inputResource, inputValue);
            }
        }
        foreach (var item in resources)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}

