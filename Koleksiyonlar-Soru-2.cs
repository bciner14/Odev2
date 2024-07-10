using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];

        Console.WriteLine("Lütfen 20 adet sayı giriniz:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen tekrar deneyin:");
            }
        }

        // En büyük 3 sayıyı bulma
        Array.Sort(numbers);
        Array.Reverse(numbers);
        int[] largestThree = new int[3];
        Array.Copy(numbers, largestThree, 3);

        // En küçük 3 sayıyı bulma
        int[] smallestThree = new int[3];
        Array.Copy(numbers, smallestThree, 3);

        // Küçükten büyüğe sıralama
        Array.Sort(smallestThree);

        // En büyük 3 sayıların ortalaması
        double averageLargest = GetAverage(largestThree);

        // En küçük 3 sayıların ortalaması
        double averageSmallest = GetAverage(smallestThree);

        // Toplam ortalamalar
        double totalAverage = (averageLargest + averageSmallest) / 2;

        // Sonuçları yazdırma
        Console.WriteLine($"\nEn büyük 3 sayı: {string.Join(", ", largestThree)}, Ortalama: {averageLargest:F2}");
        Console.WriteLine($"En küçük 3 sayı: {string.Join(", ", smallestThree)}, Ortalama: {averageSmallest:F2}");
        Console.WriteLine($"Toplam Ortalama: {totalAverage:F2}");
    }

    // Ortalama hesaplama fonksiyonu
    static double GetAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return (double)sum / array.Length;
    }
}
