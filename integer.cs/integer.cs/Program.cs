using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            int sum = SumOfDigits(number);
            Console.WriteLine("Sum of digits: " + sum);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }

    static int SumOfDigits(int num)
    {
        int sum = 0;
        num = Math.Abs(num);  // Handle negative numbers

        while (num > 0)
        {
            sum += num % 10;  // Get the last digit
            num /= 10;        // Remove the last digit
        }

        return sum;
    }
}
