using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Pride and Prejudice – Love, Humor, and Darcy!", "Book Lovers Channel", 600),
            new Video("Why Emma is Austen’s Most Playful Heroine", "Literature Buffs", 720),
            new Video("Sense and Sensibility – A Journey of Contrast", "Classic Reads", 900),
            new Video("Persuasion – The Power of Second Chances", "Austen Aficionados", 840)
        };

        videos[0].AddComment(new Comment("Alice", "Elizabeth Bennet is my favorite literary character!"));
        videos[0].AddComment(new Comment("Bob", "Darcy's character growth is incredible."));
        videos[0].AddComment(new Comment("Kate", "I love this book!"));
        videos[1].AddComment(new Comment("Charlie", "Loved the comparison to modern adaptations like Clueless!"));
        videos[1].AddComment(new Comment("Dana", "Emma’s matchmaking chaos is so entertaining."));
        videos[1].AddComment(new Comment("Jared", "I don't understand what is going on."));
        videos[2].AddComment(new Comment("Eve", "The contrast between Elinor and Marianne is so well done."));
        videos[2].AddComment(new Comment("Frank", "Sense and Sensibility is a timeless masterpiece."));
        videos[2].AddComment(new Comment("Abby", "It would be hard to live during those times!"));
        videos[3].AddComment(new Comment("Henry", "That love letter from Captain Wentworth is everything!"));
        videos[3].AddComment(new Comment("Lilly", "This is kind of a sad story, two lovers torn apart by family expectations."));
        videos[3].AddComment(new Comment("Brian", "I love a good happy ending!"));

        Console.WriteLine("Jane Austen Book Reviews:");
        foreach (var video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}