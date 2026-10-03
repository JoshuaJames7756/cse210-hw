using System;
using System.Collections.Generic;

/// <summary>
/// Encourages positive reflection by guiding the user to list as many items as possible within a topic.
/// </summary>
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    /// <summary>
    /// Initializes a new instance of the <see cref="ListingActivity"/> class.
    /// </summary>
    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    /// <summary>
    /// Executes the listing activity workflow and summarizes user responses.
    /// </summary>
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userList = GetListFromUser();
        _count = userList.Count;

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    /// <summary>
    /// Selects a random prompt for the listing exercise.
    /// </summary>
    /// <returns>A random prompt string.</returns>
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    /// <summary>
    /// Captures line-by-line user console inputs until the session duration expires.
    /// </summary>
    /// <returns>A collection of non-empty user entries.</returns>
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        return items;
    }
}