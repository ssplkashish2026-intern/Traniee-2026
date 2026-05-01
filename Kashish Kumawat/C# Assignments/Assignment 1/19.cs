using System;

class Program
{
    static void Main()
    {
        int[] num = new int[10];
        int sum = 0, max, min;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter Number: ");
            num[i] = Convert.ToInt32(Console.ReadLine());
            sum += num[i];
        }

        max = num[0];
        min = num[0];

        for (int i = 1; i < 10; i++)
        {
            if (num[i] > max)
                max = num[i];

            if (num[i] < min)
                min = num[i];
        }

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + sum / 10);
        Console.WriteLine("Maximum = " + max);
        Console.WriteLine("Minimum = " + min);

        Console.WriteLine("Reverse Order:");
        for (int i = 9; i >= 0; i--)
        {
            Console.Write(num[i] + " ");
        }
    }
}