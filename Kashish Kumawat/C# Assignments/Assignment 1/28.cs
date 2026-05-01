using System;

class Vehicle
{
    public string brand;
    public string model;
    public int rate;

    public void Show()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Rate: " + rate);
    }
}

class Car : Vehicle
{
    public Car()
    {
        brand = "Mahindra";
        model = "Scorpio";
        rate = 2500000;
    }
}

class Bike : Vehicle
{
    public Bike()
    {
        brand = "Royal Enfield";
        model = "Hunter 350";
        rate = 150000;
    }
}

class Truck : Vehicle
{
    public Truck()
    {
        brand = "Tata";
        model = "Truck";
        rate = 200000;
    }
}

class Program
{
    static void Main()
    {
        int choice;

        Console.WriteLine("1. Car 2. Bike 3. Truck");

        Console.Write("Enter Choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Car c = new Car();
            c.Show();
        }
        else if (choice == 2)
        {
            Bike b = new Bike();
            b.Show();
        }
        else if (choice == 3)
        {
            Truck t = new Truck();
            t.Show();
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }
}