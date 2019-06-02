using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        endDate = endDate.AddDays(1);
        var holidays = new string[11] { "0101", "0303", "0105", "0605", "2405", "0609", "2209", "0111", "2412", "2512", "2612"};
        var allDaysBetween = (endDate - startDate).TotalDays;
        while (startDate != endDate)
        {
            string day = startDate.Day.ToString(), month =  startDate.Month.ToString();
            if (startDate.Day < 10)
                day = "0" + startDate.Day.ToString();
            if (startDate.Month < 10)
                month = "0" + startDate.Month.ToString();
            if (startDate.DayOfWeek.ToString() == "Saturday" || startDate.DayOfWeek.ToString() == "Sunday" || holidays.Contains(day + month))
            {
                allDaysBetween--;
            }
            startDate = startDate.AddDays(1);
        }
        Console.WriteLine(allDaysBetween);
    }
}