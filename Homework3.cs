namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.Write("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        bool isPrime = true;
        
        if (N <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        
        if (isPrime)
        {
            Console.WriteLine($"{N} is a prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }
        Console.WriteLine();
        
        // Code for Q2
        Console.Write("Assign an int value to N: ");
        int N2 = Convert.ToInt32(Console.ReadLine());
        
        for (int row = 0; row < N2; row++)
        {
            for (int col = 0; col < N2; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        // Code for Q3
        Console.Write("Assign an int value to N: ");
        int N3 = Convert.ToInt32(Console.ReadLine());
        
        for (int row = 1; row <= N3; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        // Code for Bonus
        Console.Write("Assign an int value to N: ");
        int N4 = Convert.ToInt32(Console.ReadLine());
        
        for (int row = 1; row <= N4; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(row);
            }
            Console.WriteLine();
        }
    }
}