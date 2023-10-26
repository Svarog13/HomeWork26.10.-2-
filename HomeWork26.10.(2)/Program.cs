using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the digit: ");
        int number = int.Parse(Console.ReadLine());

        bool isPalindrom = IsPalindrome(number);
        if (isPalindrom)
        {
            Console.WriteLine($"{number} is a palindrome. ");
        }
        else
        {
            Console.WriteLine($"{number} is a not palindrome. ");

        }

        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number = number / 10;
            }
            return originalNumber == reversedNumber;
        }
    }
}
