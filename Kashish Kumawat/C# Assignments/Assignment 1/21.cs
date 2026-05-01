using System;

class Program
{
    static void Main()
    {
        string[] name = new string[10];
        string[] phone = new string[10];
        int choice = 0, count = 0;

    while (choice != 4)
        {
            Console.WriteLine("\n1. Add 2. Search 3. Display All 4. Exit");
            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter Name: ");
                name[count] = Console.ReadLine();

                Console.Write("Enter Phone: ");
                phone[count] = Console.ReadLine();

                count++;
            }
            else if (choice == 2)
            {
                Console.Write("Enter a name to search: ");
                string search = Console.ReadLine();

                for (int i = 0; i < count; i++)
                {
                    if (name[i] == search)
                    {
                        Console.WriteLine("Phone = " + phone[i]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number");
                    }
                }
            }
            else if (choice == 3)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(name[i] + " - " + phone[i]);
                }
            }
            else
            {
                Console.WriteLine("Exiting from the contact book..");
            }
        }
    }
}