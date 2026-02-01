namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Q1 Code:
        Console.WriteLine("Grade Classification");
        Console.Write("Enter the score: ");
        int score = Convert.ToInt32(Console.ReadLine());
        
        if (score >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (score >= 80) 
        {
            Console.WriteLine("Grade: B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
        Console.WriteLine();

        // Q2 Code:
        Console.WriteLine("Find Smallest Number");
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());
        
        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());
        
        int smallest;
        
        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                smallest = num1;
            }
            else
            {
                smallest = num3;
            }
        }
        else
        {
            if (num2 <= num3)
            {
                smallest = num2;
            }
            else
            {
                smallest = num3;
            }
        }
        
        Console.WriteLine($"The smallest value is: {smallest}");
        Console.WriteLine();

        // Bonus question code:
        Console.WriteLine("Leap Year Checker");
        Console.Write("Enter a year: ");
        int year = Convert.ToInt16(Console.ReadLine());
        
        bool isLeapYear;
        
        if (year % 400 == 0)
        {
            isLeapYear = true;
        }
        else if (year % 100 == 0)
        {
            isLeapYear = false;
        }
        else if (year % 4 == 0)
        {
            isLeapYear = true;
        }
        else
        {
            isLeapYear = false;
        }
        
        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}