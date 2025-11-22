class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments);
    }

    public int GetNumberComment()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}