public class SimpleGoal : Goal{
    private bool _isComplete;

    public bool Complete => _isComplete;

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points){
        _isComplete = false;
    }

    public override void RecordEvent(){
        _isComplete = true;
        Console.WriteLine($"You earned {_points} points for completing {_name}!");
    }

        public override bool IsComplete(){
        return _isComplete;
    }

        public override string GetDetailsString(){
        return $"[{(_isComplete ? "X" : " ")}] {_name} - {_desc}";
    }

    public override string GetStringRepresentation(){
        return $"SimpleGoal|{_name}|{_desc}|{_points}|{_isComplete}";
    }
}

