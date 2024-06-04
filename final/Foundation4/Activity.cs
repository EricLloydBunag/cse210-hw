public abstract class Activity{
    protected DateTime _activityDate;
    protected int _activityLength;

    public Activity(DateTime activityDate, int activityLength){
        _activityDate = activityDate;
        _activityLength = activityLength;
    }

    public DateTime GetDate(){ return _activityDate;}
    public int GetActivityLength(){ return _activityLength;}


     public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary(){
        return $"{_activityDate.ToShortDateString()} {GetType().Name} ({_activityLength} min)\nDistance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()} min per mile";
    }
}