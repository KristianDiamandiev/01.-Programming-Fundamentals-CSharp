using System;

class Program
{
    static void Main()
    {
        var PeshoDmg = int.Parse(Console.ReadLine());
        var GoshoDmg = int.Parse(Console.ReadLine());
        int PeshoHP = 100, GoshoHP = 100, roundCounter = 1;
        while(PeshoHP > 0 && GoshoHP > 0)
        {
            if (roundCounter % 2 == 1)
            {
                GoshoHP -= PeshoDmg;
                if (GoshoHP > 0)
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GoshoHP);
            }
            if (roundCounter % 2 == 0)
            {
                PeshoHP -= GoshoDmg;
                if (PeshoHP > 0)
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PeshoHP);
            }
            if (roundCounter % 3 == 0 && GoshoHP > 0)
            {
                PeshoHP += 10;
                GoshoHP += 10;
            }
            roundCounter++;
        }
        if(PeshoHP > 0)
            Console.WriteLine("Pesho won in {0}th round.",roundCounter-1);
        else
            Console.WriteLine("Gosho won in {0}th round.", roundCounter-1);
    }   
}