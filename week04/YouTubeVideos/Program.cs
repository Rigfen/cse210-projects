using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Basics", "John Smith", 600);

        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for explaining this."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Learn Classes", "Jane Doe", 750);

        video2.AddComment(new Comment("Mike", "Awesome tutorial."));
        video2.AddComment(new Comment("Sarah", "This helped me a lot."));
        video2.AddComment(new Comment("Tom", "Easy to understand."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Object-Oriented Programming", "Code Master", 900);

        video3.AddComment(new Comment("Emma", "Excellent content."));
        video3.AddComment(new Comment("Noah", "Really enjoyed this."));
        video3.AddComment(new Comment("Liam", "Good examples."));

        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comment List:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}