using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score percentage: ");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        string grade = "";

        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your final grade is: {grade}");

        if (score >= 70)
        {
            Console.WriteLine("Great job! You passed.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}