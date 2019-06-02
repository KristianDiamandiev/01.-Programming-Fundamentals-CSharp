using System;

class Program
{
    static void Main()
    {
        string fName = Console.ReadLine();
        string lName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        string ID = Console.ReadLine();
        string employeeNum = Console.ReadLine();

        Console.WriteLine("First name: " + fName);
        Console.WriteLine("Last name: " + lName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + ID);
        Console.WriteLine("Unique Employee number: " + employeeNum);
    }
}

