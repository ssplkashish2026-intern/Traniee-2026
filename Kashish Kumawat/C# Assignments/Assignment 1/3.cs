using System; 
class Program {
    static void Main() {
        while (true) {
            Console.WriteLine(" 1. Addition 2. Subtration 3. Multiplication 4. Division 5.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 5)
                break;

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    Console.WriteLine("Result: " + (a + b)); 
                    break;
                case 2: 
                    Console.WriteLine("Result: " + (a - b)); 
                    break;
                case 3: 
                    Console.WriteLine("Result: " + (a * b)); 
                    break;
                case 4: 
                    Console.WriteLine("Result: " + (a / b)); 
                    break;
                default: 
                    Console.WriteLine("Invalid choice"); 
                    break;
            }
        }
    }
}