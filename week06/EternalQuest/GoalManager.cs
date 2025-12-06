class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        
    }

    private static LevelInfo[] LevelThresholds = new LevelInfo[]
    {
        new LevelInfo(0, "Initiate"),
        new LevelInfo(100, "Novice Explorer"),
        new LevelInfo(500, "Apprentice Quester"),
        new LevelInfo(1000, "Journeyman"),
        new LevelInfo(2500, "Master of the List"),
        new LevelInfo(5000, "Eternal Champion")
    };

    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayPlayerInfo();

            Console.Write("Menu Options:\n"+
                "   1. Create New Goal\n"+
                "   2. List Goals\n"+
                "   3. Save Goals\n"+
                "   4. Load Goals\n"+
                "   5. Record Event\n"+
                "   6. Quit\n"+
                "Select a choice from the menu: ");
        
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                running = false;
            }
            Console.WriteLine();
        }
    }

    public (int level, string title) GetPlayerRank()
    {
        int currentLevel = 0;
        string currentTitle = LevelThresholds[0].GetTitle();

        for (int i = 0; i < LevelThresholds.Length; i++)
        {
            if (_score >= LevelThresholds[i].GetPoints())
            {
                currentLevel = i + 1;
                currentTitle = LevelThresholds[i].GetTitle();
            }
        }
        return (currentLevel, currentTitle);
    }

    public void DisplayPlayerInfo()
    {
        var rankInfo = GetPlayerRank();
        int level = rankInfo.level;
        string title = rankInfo.title;

        Console.WriteLine($"You have {_score} points.\n");
        Console.WriteLine($"Current Rank: **Level {level} - {title}**\n");
    }

    public void ListGoalNames()
    {
        int number = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetShortName()}");
            number++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int number = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetDetailsString()}");
            number++;
        }
    }

    public void CreateGoal()
    {
        Console.Write("The types of Goals are:\n"+
                "   1. Simple Goal\n"+
                "   2. Eternal Goal\n"+
                "   3. Checklist Goal\n"+
                "Which type of Goal would you like to create? ");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();

        Console.Write("How many points does this goal earn? ");
        string points = Console.ReadLine();

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        var oldRankInfo = GetPlayerRank();
        int oldLevel = oldRankInfo.level;

        Console.WriteLine("The goals are:");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        choice--;

        if (choice < 0 || choice >= _goals.Count)
        {
            Console.WriteLine("Invalid goal.");
            return;
        }

        Goal goal = _goals[choice];

        if (goal is SimpleGoal simple && simple.IsComplete())
        {
            Console.WriteLine("This Simple Goal is already complete. No points earned this time.");
            return;
        }

        goal.RecordEvent();

        _score += int.Parse(goal.GetPoints());
        int earnedPoints = int.Parse(goal.GetPoints());

        if (goal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
            {
                _score += checklist.GetBonus();
                earnedPoints += checklist.GetBonus();
            }
        }

        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");

        var newRankInfo = GetPlayerRank();
        int newLevel = newRankInfo.level;
        string newTitle = newRankInfo.title;

        if (newLevel > oldLevel)
        {
            Console.WriteLine("\n*** LEVEL UP! ***");
            Console.WriteLine($"You reached **Level {newLevel}** and earned the title: **{newTitle}**!");
            Console.WriteLine("*****************\n");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',',':');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
    }
}