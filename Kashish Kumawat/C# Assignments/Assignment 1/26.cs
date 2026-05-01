using System;

class Program
{
    static void Main()
    {
        string name = "";
        int roll = 0;
        int marks = 0;
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\n1. Add Student 2. Add Marks 3. Show Average 4. Show Details 5. Search 6. Exit");

            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();

                Console.Write("Enter Roll: ");
                roll = Convert.ToInt32(Console.ReadLine());
            }
            else if (choice == 2)
            {
                Console.Write("Enter Marks: ");
                marks = Convert.ToInt32(Console.ReadLine());
            }
            else if (choice == 3)
            {
                Console.WriteLine("Average = " + marks);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Roll: " + roll);
                Console.WriteLine("Marks: " + marks);
            }
            else if (choice == 5)
            {
                Console.Write("Enter Roll to Search: ");
                int r = Convert.ToInt32(Console.ReadLine());

                if (r == roll)
                {
                    Console.WriteLine("Found: " + name + " " + marks);
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
            else
            {
                Console.WriteLine("Exiting from the program..");
            }
        }
    }
}