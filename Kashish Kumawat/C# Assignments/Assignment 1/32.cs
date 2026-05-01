using System;
interface IPayment
{
    void ProcessPayment();
}

class CreditCard : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Payment done using Credit Card");
    }
}

class DebitCard : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Payment done using Debit Card");
    }
}

class Cash : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Payment done using Cash");
    }
}

class UPI : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Payment done using UPI");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. Debit Card");
        Console.WriteLine("3. Cash");
        Console.WriteLine("4. UPI");

        Console.Write("Choose Payment Method: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
            payment = new CreditCard();
        else if (choice == 2)
            payment = new DebitCard();
        else if (choice == 3)
            payment = new Cash();
        else if (choice == 4)
            payment = new UPI();
        else
            Console.WriteLine("Invalid choice");
    }
}