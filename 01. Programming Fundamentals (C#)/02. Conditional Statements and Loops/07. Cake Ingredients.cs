using System;

class Program
{
    static void Main()
    {
        var ingredientsCounter = 0;
        while (0 == 0)
        {
            var ingredient = Console.ReadLine();
            if (ingredient == "Bake!")
                break;
            else
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                ingredientsCounter++;
            }
        }
        Console.WriteLine("Preparing cake with {0} ingredients.", ingredientsCounter);
    }
}

