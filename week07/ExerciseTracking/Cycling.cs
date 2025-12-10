class Cycling : FitnessCenter
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) 
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (GetMinutes() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}