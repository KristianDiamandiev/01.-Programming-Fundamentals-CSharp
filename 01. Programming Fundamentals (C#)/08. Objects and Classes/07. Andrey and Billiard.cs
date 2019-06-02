using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    class Customer
    {
        public string Name { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
    }

    static Customer CreateCustomer(string input)
    {
        var OneCustomer = new Customer();
        string[] seperateInput = input.Split('-', ',');
        OneCustomer.Name = seperateInput[0];
        OneCustomer.Product = seperateInput[1];
        OneCustomer.Quantity = int.Parse(seperateInput[2]);
        return OneCustomer;
    }

    static void Main()
    {
        Dictionary<string, decimal> Menu = new Dictionary<string, decimal>();

        int numOfProducts = int.Parse(Console.ReadLine());
        while (numOfProducts-- != 0)
        {
            string[] inputProduct = Console.ReadLine().Split('-');
            if (Menu.ContainsKey(inputProduct[0]))
            {
                Menu[inputProduct[0]] = decimal.Parse(inputProduct[1]);
            }
            else
            {
                Menu.Add(inputProduct[0], decimal.Parse(inputProduct[1]));
            }
        }

        List<Customer> customers = new List<Customer>();
        string inputCustomer = Console.ReadLine();
        while (inputCustomer != "end of clients")
        {
            customers.Add(CreateCustomer(inputCustomer));
            inputCustomer = Console.ReadLine();
        }

        customers = customers.OrderBy(x => x.Name).ToList();
        decimal totalBill = 0;
        foreach (var customer in customers)
        {
            if (Menu.ContainsKey(customer.Product))
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine($"-- {customer.Product} - {customer.Quantity}");
                Console.WriteLine($"Bill: {(Menu[customer.Product] * customer.Quantity):F2}");
                totalBill += (Menu[customer.Product] * customer.Quantity);
            }
        }
        Console.WriteLine("Total bill: {0:F2}",totalBill);
    }
}


