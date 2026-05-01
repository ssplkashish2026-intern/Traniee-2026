using System;

class Program
{
    static void Main()
    {
        int members, age, totalPrice = 0;

        Console.Write("Enter number of family members: ");
        members = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= members; i++)
        {
            Console.Write("Enter age of member " + i + ": ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 5)
            {
                totalPrice += 0;
            }
            else if (age >= 5 && age <= 12)
            {
                totalPrice += 10;
            }
            else if (age >= 13 && age <= 60)
            {
                totalPrice += 25;
            }
            else
            {
                totalPrice += 15;
            }
        }

        Console.WriteLine("Total Ticket Price = $" + totalPrice);
    }
}