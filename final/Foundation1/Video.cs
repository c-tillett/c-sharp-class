using System;
using System.Reflection;
using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }
    public int GetCommentNumber()
    {
        int commentNumber = _commentList.Count();
        return commentNumber;
    }
    public List<Comment> GetComments()
    {
        List<Comment> commentList = _commentList;
        return commentList;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_author} - {_title} ({_length} seconds)");
    }
}