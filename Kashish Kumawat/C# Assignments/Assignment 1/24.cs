using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = 0; i < n; i++)
        {
            for (int space = 0; space < n - i; space++)
            {
                Console.Write(" ");
            }
    
            int num = 0;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(num + " ");
                num = num * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }
}