using System;

class Program
{
    static void Main(string[] args)
    {
        ShowWelcome();

        string name = GetUserName();
        int favoriteNumber = GetUserNumber();

        int result = CalculateSquare(favoriteNumber);

        ShowResult(name, result);
    }

    static void ShowWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int CalculateSquare(int val)
    {
        return val * val;
    }

    static void ShowResult(string fullName, int squareVal)
    {
        Console.WriteLine($"{fullName}, the square of your number is {squareVal}");
    }
}