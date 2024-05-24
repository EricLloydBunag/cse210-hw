public class GoalManager{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private string _milestone;

    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start(){
        bool exit = false;
        while (!exit){
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }    public void DisplayPlayerInfo(){
        _level = _score / 1000;
        _milestone = (_level >= 15) ? "Overachiever" :
                 (_level >= 10) ? "Veteran" :
                 (_level >= 6) ? "Adept" :
                 (_level >= 3) ? "Rookie" :
                 "Newbie";
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine($"Level {_level} {_milestone}");
    }

    public void ListGoalDetails(){
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(){
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (choice){
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid option.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal added successfully!");
    }

    public void RecordEvent(){
        Console.WriteLine("Select the goal to record event:");
        for (int i = 0; i < _goals.Count; i++){
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= _goals.Count){
            Console.WriteLine("Invalid option.");
            return;
        }

        Goal goal = _goals[choice];
        if (goal is SimpleGoal simpleGoal){
            if (simpleGoal.IsComplete()){
                Console.WriteLine("You've already completed this goal!");
                return;
            }
        else if (goal is ChecklistGoal checklistGoal){
            if (checklistGoal.IsComplete()){
                _score += checklistGoal.Bonus;
            }
            }
        }
        goal.RecordEvent();
        _score += goal.Points;
    }

    private void SaveGoals(){
        Console.WriteLine("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename)){
            writer.WriteLine(_score);
            foreach (var goal in _goals){
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals(){
        Console.WriteLine("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename)){
            using (StreamReader reader = new StreamReader(filename)){
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null){
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type){
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            var simpleGoal = new SimpleGoal(name, description, points);
                            if (isComplete) simpleGoal.RecordEvent();
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int amountCompleted = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                            for (int i = 0; i < amountCompleted; i++){
                                checklistGoal.RecordEvent();
                            }
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else{
            Console.WriteLine("File not found.");
        }
    }
}