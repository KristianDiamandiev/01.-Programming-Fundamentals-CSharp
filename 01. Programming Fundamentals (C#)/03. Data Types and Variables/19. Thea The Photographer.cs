using System;

class Program
{
    static void Main()
    {
        double picturesTaken = double.Parse(Console.ReadLine());
        double singleFilteringTime = double.Parse(Console.ReadLine());
        double percentageOfGoodPictures = double.Parse(Console.ReadLine());
        double uploadTimeForSinglePic = double.Parse(Console.ReadLine());

        double goodPictures = Math.Ceiling(picturesTaken * percentageOfGoodPictures / 100);
        double filterTime = picturesTaken * singleFilteringTime;
        double totalTime = filterTime + goodPictures * uploadTimeForSinglePic;
        //TimeSpan tmp = TimeSpan.FromSeconds((double)totalTime);
        //Console.WriteLine(tmp.ToString(@"d\:hh\:mm\:ss"));
        Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", (long)totalTime / 60 / 60 / 24, (long)totalTime / 60 / 60 % 24, (long)totalTime / 60 % 60, (long)totalTime % 60);
    }
}

