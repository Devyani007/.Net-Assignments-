using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindromeRecursive(number, 0, number))
            Console.WriteLine($"{number} is a Palindrome.");
        else
            Console.WriteLine($"{number} is NOT a Palindrome.");
    }

    static bool IsPalindromeRecursive(int num, int reversed, int original)
    {
        if (num == 0) return original == reversed;
        return IsPalindromeRecursive(num / 10, reversed * 10 + num % 10, original);
    }

   
}

