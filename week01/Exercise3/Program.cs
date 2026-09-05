using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);

        int userGuess = 0;

        while (userGuess != targetNumber)
        {
            Console.Write("Enter your guess: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < targetNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > targetNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}