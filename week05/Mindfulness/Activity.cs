using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// Represents the base class for all mindfulness activities.
/// Handles common features such as user prompts, timers, and UI animations.
/// </summary>
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    /// <summary>
    /// Initializes a new instance of the <see cref="Activity"/> class.
    /// </summary>
    /// <param name="name">The display name of the activity.</param>
    /// <param name="description">A brief description of the activity's purpose.</param>
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    /// <summary>
    /// Displays the standardized opening message, description, and prompts the user for session duration.
    /// </summary>
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        
        // Input validation loop to ensure a valid positive integer duration
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid positive number of seconds: ");
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    /// <summary>
    /// Displays the standardized closing message acknowledging completion and session duration.
    /// </summary>
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    /// <summary>
    /// Displays an animated loading spinner in the console for a specified duration.
    /// </summary>
    /// <param name="seconds">The duration in seconds to display the animation.</param>
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    /// <summary>
    /// Displays a numerical countdown timer in the console.
    /// </summary>
    /// <param name="seconds">The starting number for the countdown.</param>
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}