using System;
using System.Collections.Generic;
using System.Linq;

public class SumAdjacentEqualNumbers
{
    public static List<double> SumAdjacentEqual(List<double> numbers)
    {
        List<double> result = new List<double>();
        int i = 0;
        while (i < numbers.Count)
        {
            double currentNumber = numbers[i];
            int j = i + 1;
            while (j < numbers.Count && numbers[j] == currentNumber)
            {
                currentNumber += numbers[j];
                j++;
            }
            result.Add(currentNumber);
            i = j;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a list of decimal numbers separated by spaces: ");
        string numbersStr = Console.ReadLine();

        List<double> numbers = numbersStr.Split(' ')
                                     .Select(double.Parse)
                                     .ToList();

        List<double> result = SumAdjacentEqual(numbers);

        Console.WriteLine(string.Join(" ", result));
    }
}
