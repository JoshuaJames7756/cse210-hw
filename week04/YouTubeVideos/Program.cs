using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Object Oriented Programming Tutorial", "CodeAcademy", 780);
        video1.AddComment(new Comment("Alex99", "Great explanation of abstraction!"));
        video1.AddComment(new Comment("Maria_Dev", "This made C# classes so easy to understand."));
        video1.AddComment(new Comment("JohnDoe", "Thanks for the clear examples."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("10 Tips for Writing Clean Code", "TechLead", 450);
        video2.AddComment(new Comment("CoderPro", "Tip #3 was super useful!"));
        video2.AddComment(new Comment("Sam_Smith", "Nice video, short and to the point."));
        video2.AddComment(new Comment("Lucia_R", "I always forget naming conventions, good reminder."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Building web apps with ASP.NET Core", "DevSolutions", 1200);
        video3.AddComment(new Comment("Carlos_B", "Can you make a part 2 on databases?"));
        video3.AddComment(new Comment("Anna_K", "Very helpful walkthrough."));
        video3.AddComment(new Comment("Kevin_M", "Awesome content as always!"));
        videos.Add(video3);

        // Information for each video
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}