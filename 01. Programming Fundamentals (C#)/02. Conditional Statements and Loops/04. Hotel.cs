using System;

class Program
{
    static void Main()
    {
        var month = Console.ReadLine();
        var nightsAmount = int.Parse(Console.ReadLine());
        var studioPrice = 0.0;
        var doublePrice = 0.0;
        var suitePrice = 0.0;
        var flagFreeNight = 0;
        if (month == "May" || month == "October")
        {
            if (nightsAmount > 7)
            {
                studioPrice = 50.0 * 0.95;
                if (month == "October")
                    flagFreeNight = 1;
            }
            else
                studioPrice = 50.0;
            doublePrice = 65.0;
            suitePrice = 75.0;
            var totalStudioPrice = nightsAmount * studioPrice;
            if (flagFreeNight == 1)
                totalStudioPrice = totalStudioPrice - studioPrice;
            Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.", totalStudioPrice, nightsAmount*doublePrice, nightsAmount*suitePrice);
        }
        else if (month == "June" || month == "September")
        {
            if (month == "September" && nightsAmount > 7)
                flagFreeNight = 1;
            studioPrice = 60.0;
            if (nightsAmount > 14)
                doublePrice = 72.0 * 0.90;
            else
                doublePrice = 72.0;
            suitePrice = 82.0;
            var totalStudioPrice = nightsAmount * studioPrice;
            if (flagFreeNight == 1)
                totalStudioPrice = totalStudioPrice - studioPrice;
            Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.", totalStudioPrice, nightsAmount * doublePrice, nightsAmount * suitePrice);
        }
        else
        {
            studioPrice = 68.0;
            doublePrice = 77.0;
            if (nightsAmount > 14)
                suitePrice = 89.0 * 0.85;
            else
                suitePrice = 89.0;
            var totalStudioPrice = nightsAmount * studioPrice;
            Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.", totalStudioPrice, nightsAmount * doublePrice, nightsAmount * suitePrice);
        }
    }
}

