using System;
using System.Collections.Generic;
using System.Linq;

public class SumInOrder
{
    public static List<double> SumInOrderFunc(List<double> numbers)
    {
        if (numbers == null)
        {
            return null;
        }

        if (numbers.Count == 0)
        {
            return new List<double>(); // Return an empty list for empty input
        }

        int n = numbers.Count;
        List<double> result = new List<double>();

        for (int i = 0; i < n / 2 + n % 2; i++)
        {
            double currentSum = numbers[i];
            if (i != n - 1 - i) // Avoid double-counting the middle element in odd-length lists
            {
                currentSum += numbers[n - 1 - i];
            }
            result.Add(currentSum);
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers separated by spaces: ");
        string numbersStr = Console.ReadLine();

        List<double> numbers = new List<double>();
        try
        {
            numbers = numbersStr.Split(' ')
                                 .Select(double.Parse)
                                 .ToList();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numbers only.");
            return; // Exit the program if input is invalid
        }


        List<double> result = SumInOrderFunc(numbers);

        if (result == null)
        {
            Console.WriteLine("Invalid Input");
        }
        else if (result.Count == 0)
        {
            Console.WriteLine("Empty List");
        }
        else
        {
            Console.WriteLine(string.Join(" ", result));
        }

    }
}