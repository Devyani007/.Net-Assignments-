using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || input.Length < 2)
        {
            Console.WriteLine("String should have at least two characters.");
        }
        else
        {
            string shuffledString = ShuffleFirstAndLast(input);
            Console.WriteLine("Shuffled String: " + shuffledString);
        }
    }

    static string ShuffleFirstAndLast(string str)
    {
        if (str.Length < 2) return str;

        char first = str[0];
        char last = str[^1];

        return last + str.Substring(1, str.Length - 2) + first;
    }
}

