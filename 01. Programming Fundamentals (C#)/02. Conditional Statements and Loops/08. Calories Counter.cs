using System;

class Program
{
    static void Main()
    {
        var ingredientsNum = int.Parse(Console.ReadLine());
        var amountCalories = 0;
        string ingredient;
        for (int i=0; i < ingredientsNum; i++)
        {
            ingredient = Console.ReadLine();
            if (ingredient.ToLower() == "cheese")
                amountCalories += 500;
            else if (ingredient.ToLower() == "tomato sauce")
                amountCalories  += 150;
            else if (ingredient.ToLower() == "salami")
                amountCalories += 600;
            else if (ingredient.ToLower() == "pepper")
                amountCalories += 50;
        }
        Console.WriteLine("Total calories: {0}", amountCalories);
    }
}

