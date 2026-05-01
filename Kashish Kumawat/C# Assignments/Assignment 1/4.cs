using System;
class Program {
    static void Main() {
        Console.Write("Enter 3 numbers to find largest: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
    
        if (a >= b && a >= c)
        {
            Console.WriteLine("Largest number is: " + a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Largest number is: " + b);
        }
        else
        {
            Console.WriteLine("Largest number is: " + c);
        }
    }
}