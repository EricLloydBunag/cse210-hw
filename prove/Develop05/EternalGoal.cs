public class EternalGoal : Goal{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points){}

    public override void RecordEvent(){
         Console.WriteLine($"You earned {_points} points for recording {_name}!");
    }
    public override bool IsComplete(){
        return false;
    }

    public override string GetDetailsString(){
        return $"[ ] {_name} - {_desc}";
    }

    public override string GetStringRepresentation(){
        return $"EternalGoal|{_name}|{_desc}|{_points}";
    }
}