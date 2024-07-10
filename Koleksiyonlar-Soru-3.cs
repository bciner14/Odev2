using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle giriniz:");
        string sentence = Console.ReadLine();

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        List<char> vowelList = new List<char>();

        foreach (char ch in sentence)
        {
            if (Array.IndexOf(vowels, ch) != -1)
            {
                if (!vowelList.Contains(ch))
                {
                    vowelList.Add(ch);
                }
            }
        }

        vowelList.Sort();

        Console.WriteLine("\nCümledeki sesli harfler:");
        foreach (char vowel in vowelList)
        {
            Console.WriteLine(vowel);
        }
    }
}
