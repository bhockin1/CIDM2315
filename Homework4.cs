namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        Console.WriteLine("a = 3; b=5");
        int result = Q1_method(3, 5);
        Console.WriteLine($"The largest number is: {result}");
        Console.WriteLine();
        
        // Call Q2_method()
        Q2_method(5, "left");
        Console.WriteLine();
        Q2_method(5, "right");
    }

    // Q1_method
    static int Q1_method(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    // Q2_method
    static void Q2_method(int N, string shape)
    {
        Console.WriteLine($"N is: {N}; shape is {shape}");
        
        if (shape == "left")
        {
            for (int row = 1; row <= N; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "right")
        {
            for (int row = 1; row <= N; row++)
            {
                for (int space = 1; space <= N - row; space++)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}