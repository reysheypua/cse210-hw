using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Ya'll mind if I complain for 15 minutes?", "JaidenAnimations", 899);
        video1.AddComment(new Comment("LatentCC", "Cars aren't turning into computers. It's worse. They're turning into printers."));
        video1.AddComment(new Comment("V M", "I'm sorry Jaiden, you're going to have to buy a complaining subscription to complain for 15 minutes."));
        video1.AddComment(new Comment("Keely M", "Funfactt: It is more expensive for car companies to put buttons in cars. Smart screens are cheaper yet still displayed as a luxury."));

        Video video2 = new Video("Filipino Food Taste Test (Eat It or Yeet It)", "Smosh Pit", 1505);
        video2.AddComment(new Comment("Milusiek", "Angela unleashing the pure chaos by slapping the soda bag is an absolute mood"));
        video2.AddComment(new Comment("Sakura Ishimaru", "For someone who got bullied bringing filipino food to school 15 years ago, this was really healing to watch. Thank you."));
        video2.AddComment(new Comment("Kamen rider#1", "giving them chicken adobo without reheating it is just cruel"));

        Video video3 = new Video("The Deserved Downfall of Duolingo", "Internet Anarchist", 1483);
        video3.AddComment(new Comment("SuperSpatman", "The recent change from hearts to energy has ruined the experience. You now lose energy even when you don't make mistakes."));
        video3.AddComment(new Comment("Quick Question", "Duo went from 'Spanish or vansish' to 'AI or goodbye'"));
        video3.AddComment(new Comment("hermanmunchther3082", "Too bad all companies cant realize that actually listening to customers makes more money"));
        video3.AddComment(new Comment("Mike Sloppy", "They could translate everything except customer satisfaction."));

        List<Video> videos = new List<Video>{video1, video2, video3};

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Video Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length of video in seconds: {video.GetDuration()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberComment()}");

            Console.WriteLine("");
            Console.WriteLine("------------COMMENTS------------");

            int commentCounter = 1;

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"Comment {commentCounter}:");
                Console.WriteLine($"Commenter's Name: {comment.GetName()}");
                Console.WriteLine($"Comment: {comment.GetText()}");
                Console.WriteLine("");

                commentCounter++;
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("\n");
        }
    }
}