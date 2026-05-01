using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Sentence: ");
        string text = Console.ReadLine();

        Console.WriteLine("Word Count = " + words.Length);
        Console.WriteLine("Characters With Space = " + text.Length);
        Console.WriteLine("Characters Without Space = " + text.Replace(" ", "").Length);

        string longest = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
                longest = words[i];
        }

        Console.WriteLine("Longest Word = " + longest);

        char[] arr = text.ToCharArray();
        Array.Reverse(arr);

        Console.WriteLine("Reversed Sentence = " + new string(arr));
    }
}