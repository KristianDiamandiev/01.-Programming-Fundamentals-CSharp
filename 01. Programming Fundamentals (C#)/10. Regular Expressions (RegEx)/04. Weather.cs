using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"([A-Z]{2})(\d+\.\d\d*)([A-Za-z]+)\|";
        Dictionary<string, double> CityTemperature = new Dictionary<string, double>();
        Dictionary<string, string> CityWeather = new Dictionary<string, string>();
        string text = "";
        string input = Console.ReadLine();
        while (input != "end")
        {
            text += input + "\r\n";
            input = Console.ReadLine();
        }
        foreach (Match m in Regex.Matches(text, pattern))
        {
            CityTemperature[m.Groups[1].ToString()] = double.Parse(m.Groups[2].ToString());
            CityWeather[m.Groups[1].ToString()] = m.Groups[3].ToString();
        }

        var orderedByTemp = CityTemperature.OrderBy(x => x.Value);

        foreach (var output in orderedByTemp)
        {
            Console.WriteLine("{0} => {1:F2} => {2}", output.Key, output.Value, CityWeather[output.Key]);
        }
    }
}