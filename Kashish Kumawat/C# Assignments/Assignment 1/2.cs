    using System;
class Program { 
    static void Main()  {
        Console.Write("Choose option to calculate temperature: /n 1. Celsius to Fahrenheit /n 2. Fahrenheit to Celsius");        
        int val = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (val == 1) {
            double f = (temp * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit: " + f);
        }
        else if (val == 2) {
            double c = (temp - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + c);
        }
        else {
            Console.WriteLine("Invalid choice");
        }
    }
}