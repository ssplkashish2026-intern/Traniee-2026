using System;

class Program
{
    static void Main()
    {
        int choice = 0, num, fact, i;

        while (choice != 2)
        {
            Console.WriteLine("1. Find Factorial 2. Exit");
            Console.Write("/n Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                fact = 1;
                i = 1;

                while (i <= num)
                {
                    fact = fact * i;
                    i++;
                }

                Console.WriteLine("Factorial = " + fact);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Exiting the program..");
            }
        }
    }
}