using System;

class Assignment
{
    
    static void CheckEvenOdd()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine(number + " The number is even.");
        else
            Console.WriteLine(number + " The number is odd.");
    }

    static void PrintDivisibleBy5()
    {
        Console.WriteLine("Numbers divisible by 5:");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 5 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void CalculateFactorial()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {number} is: {factorial}");
    }

    static void PrintNumbersLessThan10()
    {
        int[] numbers = { 2, 5, 12, 8, 3, 15 };

        Console.WriteLine("Numbers less than 10:");

        foreach (int num in numbers)
        {
            if (num < 10)
                Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void CheckPrime()
    {
        Console.WriteLine("Enter a number:");

        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (number <= 1)
            isPrime = false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine("The number is prime.");
        else
            Console.WriteLine("The number is not prime.");
    }

    static void CheckPalindrome()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
            Console.WriteLine("The number is a palindrome.");
        else
            Console.WriteLine("The number is not a palindrome.");
    }

    static bool IsPalindrome(int number)
    {
        int reversedNumber = ReverseNumber(number);
        return number == reversedNumber;
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;
        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number /= 10;
        }
        return reversedNumber;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Check if a number is even or odd");
        Console.WriteLine("2. Print numbers divisible by 5");
        Console.WriteLine("3. Calculate factorial of a number");
        Console.WriteLine("4. Print numbers less than 10 from a list");
        Console.WriteLine("5. Check if a number is prime");
        Console.WriteLine("6. Check if a number is palindrome");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CheckEvenOdd();
                break;
            case 2:
                PrintDivisibleBy5();
                break;
            case 3:
                CalculateFactorial();
                break;
            case 4:
                PrintNumbersLessThan10();
                break;
            case 5:
                CheckPrime();
                break;
            case 6:
                CheckPalindrome();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

}