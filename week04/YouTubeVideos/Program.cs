using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Healthy Living Tips", "Ignatia", 300);
        Video video2 = new Video("Web Development Basics", "JohnTech", 600);
        Video video3 = new Video("Digital Marketing 101", "SarahBiz", 450);

        video1.AddComment(new Comment("Alice", "Great tips!"));
        video1.AddComment(new Comment("Mark", "Very helpful."));
        video1.AddComment(new Comment("Jane", "Loved this video!"));

        video2.AddComment(new Comment("Tom", "Nice explanation."));
        video2.AddComment(new Comment("Jerry", "Clear and simple."));
        video2.AddComment(new Comment("Mike", "Thanks for sharing."));

        video3.AddComment(new Comment("Anna", "Very informative."));
        video3.AddComment(new Comment("Chris", "I learned a lot."));
        video3.AddComment(new Comment("Paul", "Awesome content!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}