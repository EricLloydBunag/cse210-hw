public abstract class Goal{
    protected string _name;
    protected string _desc;
    protected int _points;

    public string Name => _name;
    public int Points => _points;


    public Goal(string name, string desc, int points){
        _name = name;
        _desc = desc;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}