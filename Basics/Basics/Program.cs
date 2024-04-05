using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\n----- MENU -----");
            Console.WriteLine("1. Shuffle first and last character of a string");
            Console.WriteLine("2. Calculate sum of digits");
            Console.WriteLine("3. Check if a number is palindrome");
            Console.WriteLine("4. Calculate square root");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ShuffleFirstAndLastCharacter();
                        break;
                    case 2:
                        CalculateSumOfDigits();
                        break;
                    case 3:
                        CheckPalindrome();
                        break;
                    case 4:
                        CalculateSquareRoot();
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        } while (choice != 0);
    }

    static void ShuffleFirstAndLastCharacter()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        if (input.Length >= 2)
        {
            char[] characters = input.ToCharArray();
            char temp = characters[0];
            characters[0] = characters[input.Length - 1];
            characters[input.Length - 1] = temp;
            string shuffledString = new string(characters);
            Console.WriteLine("Shuffled string: " + shuffledString);
        }
        else
        {
            Console.WriteLine("String length should be at least 2 characters.");
        }
    }

    static void CalculateSumOfDigits()
    {
        Console.Write("Enter a number: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
            else
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                Console.WriteLine("Sum of digits: " + sum);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }


    static void CheckPalindrome()
    {
        Console.Write("Enter a number: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            bool isPalindrome = IsPalindrome(number);
            Console.WriteLine("Is palindrome: " + isPalindrome);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static bool IsPalindrome(int number)
    {
        int reversedNumber = 0;
        int originalNumber = number;
        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }
        return originalNumber == reversedNumber;
    }

    static void CalculateSquareRoot()
    {
        Console.Write("Enter a number: ");
        double number;
        if (double.TryParse(Console.ReadLine(), out number))
        {
            if (number >= 0)
            {
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("Square root of " + number + " is: " + squareRoot);
            }
            else
            {
                Console.WriteLine("Invalid input. Cannot calculate square root of a negative number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
