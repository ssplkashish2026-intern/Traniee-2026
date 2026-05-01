using System;

class Program
{
    static void Main()
    {
        double weight, height, bmi;

        Console.Write("Enter weight in kg: ");
        weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in meters: ");
        height = Convert.ToDouble(Console.ReadLine());

        bmi = weight / (height * height);

        Console.WriteLine("Your BMI is: " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");
            Console.WriteLine("Eat nutritious food and consult a doctor.");
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            Console.WriteLine(" Normal weight");
            Console.WriteLine("Maintain your healthy lifestyle.");
        }
        else if (bmi >= 25 && bmi < 30)
        {
            Console.WriteLine("Overweight");
            Console.WriteLine("Exercise regularly and follow a balanced diet.");
        }
        else
        {
            Console.WriteLine("Much Fatty");
            Console.WriteLine("Consult a doctor and lose your fat.");
        }
    }
}