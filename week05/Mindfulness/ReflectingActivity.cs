using System;
using System.Collections.Generic;

/// <summary>
/// Prompts the user to reflect on personal strengths and experiences through guided questions.
/// </summary>
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _unusedQuestions;

    /// <summary>
    /// Initializes a new instance of the <see cref="ReflectingActivity"/> class and populates question sets.
    /// </summary>
    public ReflectingActivity() 
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        // Initialize tracking list for non-repeating random selection
        _unusedQuestions = new List<string>(_questions);
    }

    /// <summary>
    /// Executes the reflection session lifecycle.
    /// </summary>
    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Display unique questions continuously until duration ends
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    /// <summary>
    /// Selects a random prompt from the predefined collection.
    /// </summary>
    /// <returns>A random prompt string.</returns>
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    /// <summary>
    /// Retrieves a unique question from the remaining question pool.
    /// Resets the pool if all questions have been displayed in the current session.
    /// </summary>
    /// <returns>A unique question string.</returns>
    public string GetRandomQuestion()
    {
        // Refill pool when exhausted to maintain non-repetitive selection across sessions
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        Random random = new Random();
        int index = random.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index);

        return question;
    }

    /// <summary>
    /// Formats and displays a random reflection prompt to the user interface.
    /// </summary>
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }

    /// <summary>
    /// Displays a random reflection question from the available pool.
    /// </summary>
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}