using System;
using System.Collections.Generic;

public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }
    public string GetDisplayText()
    {
        return $"{_title} by {_author} ({_length / 60}m {_length % 30}s - {NumberOfComments()} Comments)";
    }
        public void DisplayComments()
    {
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommentDisplay()}");
        }
    }

}
