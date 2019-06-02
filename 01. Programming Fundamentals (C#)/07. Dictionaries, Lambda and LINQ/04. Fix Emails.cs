using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var emails = new Dictionary<string, string>();
        string name;
        string email;
        name = Console.ReadLine();
        while (name != "stop")
        {
            email = Console.ReadLine();
            emails.Add(name, email);
            name = Console.ReadLine();
        }

        string cut;
        foreach (var item in emails)
        {
            cut = item.Value.ToLower();
            if (cut[cut.Length - 2] == 'u' && (cut[cut.Length - 1] == 's' || cut[cut.Length - 1] == 'k'))
            {
                emails.Remove(item.Key);
            }
        }
        foreach (var item in emails)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}
