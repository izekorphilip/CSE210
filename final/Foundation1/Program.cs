using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1, Philip World!");


        List<Video> videos = new List<Video>();

        Video video1 = new Video("What matter the most", "Johnson Pete", 300);
        video1.Comments.Add(new Comment("Commenter 1", "This is a great video!"));
        video1.Comments.Add(new Comment("Commenter 2", "I agree, it's awesome!"));
        video1.Comments.Add(new Comment("Commenter 3", "Thanks for sharing!"));

        Video video2 = new Video("Life in the dark", "Kelvin Lugard", 240);
        video2.Comments.Add(new Comment("Commenter 4", "This video is okay."));
        video2.Comments.Add(new Comment("Commenter 5", "I didn't like it."));
        video2.Comments.Add(new Comment("Commenter 6", "It's not bad."));

        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length} seconds, Comments: {video.GetCommentCount()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }


    public class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }


    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }
    }


}




