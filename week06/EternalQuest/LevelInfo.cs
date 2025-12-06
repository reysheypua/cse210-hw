using System.Drawing;

public class LevelInfo
{
    private int _points;
    private string _title;

    public LevelInfo(int points, string title)
    {
        _points = points;
        _title = title;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
}