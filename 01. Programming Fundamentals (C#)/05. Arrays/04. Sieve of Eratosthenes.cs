using System;

public class Program
{
 static bool IsPrime(int num)
 {
 	for(int i = 2; i <= Math.Sqrt(num); i++)
 	{
 		if (num % i == 0)
 			return false;
 	}
 	return true;
 }
 
 static void RemoveNonPrimes(int m, 
 	int i, bool[] primes2)
 {
 	int j = 2;
 	while(i * j <= m)
 	{
 		primes2[i*j] = false;
 		j++;
 	}
 }
	
 public static void Main()
 {
 	int n = int.Parse(Console.ReadLine());
 	bool[] primes = new bool[1000000];
 	for (int i=0; i <= n; i++)
 	{
 		primes[i] = true;
 	}
 	primes[0] = false;
 	primes[1] = false;
 	primes[2] = true;
 	
 	RemoveNonPrimes(n, 2, primes);
 	
 	for (int i = 3; i<=n; i++)
 	{
 		if (IsPrime(i) == true)
 		{
 			RemoveNonPrimes(n, i, primes);
 		}
 	}
 	if (n >= 2)
 	{
 		for (int i = 0; i <= n; i++)
 		{
 		if (primes[i] == true)
 				Console.Write(i + " ");
 		}
 	}
 }
}