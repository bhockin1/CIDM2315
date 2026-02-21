namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        Q1_method();
        Console.WriteLine();
        
        // Call Q2_method()
        Q2_method();
        Console.WriteLine();
        
        // Call createAccount()
        createAccount();
    }

    // Q1_method
    static void Q1_method()
    {
        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        int largest = getLargest(a, b);
        Console.WriteLine($"The largest number is: {largest}");
    }
    
    static int getLargest(int a, int b)
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
    static void Q2_method()
    {
        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        int d = Convert.ToInt32(Console.ReadLine());
        
        int max1 = getLargest(a, b);
        int max2 = getLargest(c, d);
        int max = getLargest(max1, max2);
        
        Console.WriteLine($"The largest number is: {max}");
    }

    // Q3_method
    static bool checkAge(int birth_year)
    {
        int current_year = 2026;
        int age = current_year - birth_year;
        
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    static void createAccount()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();
        
        Console.Write("Enter your password: ");
        string password1 = Console.ReadLine();
        
        Console.Write("Enter your password again: ");
        string password2 = Console.ReadLine();
        
        Console.Write("Enter your birth year: ");
        int birthyear = Convert.ToInt32(Console.ReadLine());
        
        if (checkAge(birthyear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}