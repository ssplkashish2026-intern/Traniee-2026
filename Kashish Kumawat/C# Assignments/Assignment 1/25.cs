using System;

class BankAccount
{
    public double balance;
    public string name;
    public int accNo;

    public void CreateAccount()
    {
        Console.Write("Enter your account number: ");
        accNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter name: ");
        name = Console.ReadLine();

        balance = 0;
        Console.WriteLine("Account created successfully");
    }

    public void Deposit()
    {
        Console.Write("Enter amount to deposit: ");
        double amt = Convert.ToDouble(Console.ReadLine());

        if (amt > 0)
        {
            balance += amt;
            Console.WriteLine("Amount deposited");
        }
        else
        {
            Console.WriteLine("Invalid amount");
        }
    }

    public void Withdraw()
    {
        Console.Write("Enter amount to withdraw: ");
        double amt = Convert.ToDouble(Console.ReadLine());

        if (amt <= balance)
        {
            balance -= amt;
            Console.WriteLine("Withdrawal successful");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public void ShowDetails()
    {
        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine("Account No: " + accNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Balance: " + balance);
    }
}

class Program {
    static void Main()     {
        BankAccount b = new BankAccount();

        while (true)         {
            Console.WriteLine("\n1.Create Account 2.Deposit 3.Withdraw 4.Show Details 5.Exit");

            Console.Write("Enter choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
                b.CreateAccount();

            else if (ch == 2)
                b.Deposit();

            else if (ch == 3)
                b.Withdraw();

            else if (ch == 4)
                b.ShowDetails();

            else if (ch == 5)
                Console.WriteLine("Exiting from the program..");
        }
    }
}