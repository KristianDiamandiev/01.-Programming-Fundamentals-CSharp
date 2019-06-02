using System;

class Program
{
    static void FindPrimesInRange(int startNum, int endNum)
    {
        int[] listOfPrimeNumbers = new int[10000];
        int counterOfPrimes = 0;
        while (startNum <= endNum)
        {
            if (startNum == 2 || startNum == 3)
            {
                listOfPrimeNumbers[counterOfPrimes] = startNum;
                counterOfPrimes++;
            }
            else if (startNum > 3)
            {
                bool isPrime = true;
                for (long i = 2; i <= (long)Math.Sqrt(startNum) + 1; i++)
                {
                    if (startNum % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime == true)
                {
                    listOfPrimeNumbers[counterOfPrimes] = startNum;
                    counterOfPrimes++;
                }
            }
            startNum++;
        }
        for (int i = 0; i < counterOfPrimes-1; i++)
        {
            Console.Write($"{listOfPrimeNumbers[i]}, ");
        }
        Console.WriteLine(listOfPrimeNumbers[counterOfPrimes - 1]);
    }

    static void Main()
    {
        int startingNumber = int.Parse(Console.ReadLine());
        int endingNumber = int.Parse(Console.ReadLine());
        FindPrimesInRange(startingNumber, endingNumber);
    }
}

