using System;
using System.Collections.Generic;

public class Comment {
    private string _name;
    private string _videoComment;

    public Comment(string name, string videoComment)
    {
        _name = name;
        _videoComment = videoComment;
    }

    public string GetCommentDisplay()
    {
        return $"{_name}; {_videoComment}";
    }

    
}