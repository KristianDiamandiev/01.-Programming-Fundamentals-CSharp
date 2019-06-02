using System;

public class Program
{
 static void Face (double a)
 {
 	Console.WriteLine(Math.Round(a*Math.Sqrt(2),2));
 }
	
 static void Space (double a)
 {
 	Console.WriteLine(Math.Round(a*Math.Sqrt(3),2));
 }
	
		
 static void Area (double a)
 {
 	Console.WriteLine(Math.Round(a*a*6,2));
 }
	
 static void Volume (double a)
 {
 	Console.WriteLine(Math.Round(a*a*a,2));
 }
	
 public static void Main()
 {
 	var a = double.Parse(Console.ReadLine());
 	string type = Console.ReadLine();
 	if (type == "face") Face(a);
 	else if (type == "area") Area(a);
 	else if (type == "volume") Volume(a);
 	else Space (a);
 }
}