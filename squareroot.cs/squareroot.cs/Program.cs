using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number.");

            double sqrt = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is {sqrt}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
