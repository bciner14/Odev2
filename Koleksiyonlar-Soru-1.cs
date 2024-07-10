using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();

        int count = 0;
        double sumPrime = 0, sumNonPrime = 0;

        Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz:");

        while (count < 20)
        {
            Console.Write($"Sayı {count + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
            {
                if (IsPrime(num))
                {
                    primeNumbers.Add(num);
                    sumPrime += num;
                }
                else
                {
                    nonPrimeNumbers.Add(num);
                    sumNonPrime += num;
                }
                count++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı giriniz.");
            }
        }

        // Prime numbers list sorting (descending order)
        primeNumbers.Sort();
        primeNumbers.Reverse();

        // Non-prime numbers list sorting (descending order)
        nonPrimeNumbers.Sort();
        nonPrimeNumbers.Reverse();

        // Output prime numbers
        Console.WriteLine("\nAsal Sayılar:");
        foreach (int prime in primeNumbers)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine($"\nToplam {primeNumbers.Count} adet, Ortalama: {sumPrime / primeNumbers.Count:F2}");

        // Output non-prime numbers
        Console.WriteLine("\nAsal Olmayan Sayılar:");
        foreach (int nonPrime in nonPrimeNumbers)
        {
            Console.Write(nonPrime + " ");
        }
        Console.WriteLine($"\nToplam {nonPrimeNumbers.Count} adet, Ortalama: {sumNonPrime / nonPrimeNumbers.Count:F2}");
    }

    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
