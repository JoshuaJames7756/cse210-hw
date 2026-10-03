// ===================================================================================
// Exceeding Requirements / Creativity Enhancements:
// 1. Enhanced ReflectingActivity to prevent repetitive questions: Implemented an 
//    internal question pool tracking algorithm (_unusedQuestions) that ensures questions 
//    are not repeated until all available questions in the set have been displayed.
// 2. Implemented robust input validation in Activity.cs: Guarantees that user duration 
//    inputs are strictly positive integers, preventing runtime crashes from invalid input.
// ===================================================================================

using System;

/// <summary>
/// Entry point for the Mindfulness Application.
/// Controls menu navigation and activity initialization.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        // Main application loop
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid selection. Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}