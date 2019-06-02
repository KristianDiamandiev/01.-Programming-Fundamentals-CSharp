using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = 100 * centuries;
        double days = 365.2422 * years;
         ulong hours = (ulong)days * 24;
         ulong minutes = hours * 60;
         ulong seconds = minutes * 60;
         ulong milliseconds = seconds * 1000;
         BigInteger microseconds = milliseconds * 1000;
         BigInteger nanoseconds = microseconds * 1000;
         Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, (int)days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
    }
}

