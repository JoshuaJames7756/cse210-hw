using System;

/// <summary>
/// Guides the user through a rhythmic breathing exercise to promote relaxation.
/// </summary>
public class BreathingActivity : Activity
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BreathingActivity"/> class.
    /// </summary>
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    /// <summary>
    /// Executes the main loop for the breathing activity.
    /// </summary>
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Continue alternating breath cycles until the total session duration expires
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}