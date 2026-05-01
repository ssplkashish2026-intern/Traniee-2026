using System;

interface INotification
{
    void SendNotification();
}

class EmailNotification : INotification
{
    public void SendNotification()
    {
        Console.WriteLine("Email sent");
    }
}

class SMSNotification : INotification
{
    public void SendNotification()
    {
        Console.WriteLine("SMS sent");
    }
}

class PushNotification : INotification
{
    public void SendNotification()
    {
        Console.WriteLine("Push sent");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Email 2. SMS 3. Push");

        Console.Write("Choose Notification Type: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
            notify = new EmailNotification();
        else if (choice == 2)
            notify = new SMSNotification();
        else if (choice == 3)
            notify = new PushNotification();
        else
            Console.WriteLine("Invalid choice");
    }
}