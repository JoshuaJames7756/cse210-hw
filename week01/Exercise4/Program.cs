using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputNumber = -1;

        while (inputNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }

        int totalSum = 0;
        foreach (int number in numbers)
        {
            totalSum += number;
        }

        Console.WriteLine($"The sum is: {totalSum}");

        float average = ((float)totalSum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }

        Console.WriteLine($"The max is: {maximum}");
    }
}