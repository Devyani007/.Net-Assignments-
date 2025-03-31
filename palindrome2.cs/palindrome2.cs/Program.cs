using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindrome(number))
            Console.WriteLine($"{number} is a Palindrome.");
        else
            Console.WriteLine($"{number} is NOT a Palindrome.");
    }

    static bool IsPalindrome(int num)
    {
        int original = num, reversed = 0;

        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num /= 10;
        }

        return original == reversed;
    }
}

