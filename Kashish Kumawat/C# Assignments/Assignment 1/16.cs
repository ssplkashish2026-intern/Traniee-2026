using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("How many number in series do you require:");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, c;
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}