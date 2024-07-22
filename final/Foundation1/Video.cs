using System;

public class Video 
{
    List<Comment> _comments = new List<Comment>();
    private string _title;
    private string _author;
    private int _length;
    private int _totalComments = 0;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;    
    }

    public void CommentsList(Comment comment)
    {
        _comments.Add(comment);
    }

    // Set Getters
    private string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    } 
    public int GetLength()
    {
        return _length;
    }

    public int  Comments()
    {
        _totalComments = _comments.Count();
        return _totalComments;
    }

    public void DisplayComments()
    {
        Console.WriteLine("><><><><><><><><>  Video details. <><><><><><><><><");
        Console.WriteLine($"**** Atuthor: {_author} - Title {_title} - Length in seconds: {_length}. ****");
       
    }
    
    public void Comentaries()
    {
         foreach (Comment comment in _comments)
        {
            comment.GetSumary();
        }
    }
}