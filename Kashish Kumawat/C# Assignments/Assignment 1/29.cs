using System;

class Program
{
    static void Main()
    {
        string title = "";
        int id = 0;
        bool available = true;

        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\n1. Add Book 2. Borrow Book 3. Show Details 4. Exit");
            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Title: ");
                title = Console.ReadLine();

                Console.Write("Enter ID: ");
                id = Convert.ToInt32(Console.ReadLine());

                available = true;
            }
            else if (choice == 2)
            {
                if (available)
                {
                    Console.WriteLine("Book Borrowed");
                    available = false;
                }
                else
                {
                    Console.WriteLine("Book Not Available");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Available: " + available);
            }
            else
            {
                Console.WriteLine("Exiting from the program..");
            }
        }
    }
}