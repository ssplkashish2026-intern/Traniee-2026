using System;

class Program
{
    static void Main()
    {
        int num, orgNum, rem, result = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        orgNum = num;

        while (num != 0)
        {
            rem = num % 10;
            result = result + (rem * rem * rem);
            num = num / 10;
        }

        if (result == orgNum)
        {
            Console.WriteLine("It is an Armstrong Number.");
        }
        else
        {
            Console.WriteLine("It is not an Armstrong Number.");
        }
    }
}