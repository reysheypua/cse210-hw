class LogManager
{
    private string _logFile = "mindfulness_activity_log.txt";

    public void SaveLog(string activityName, int duration)
    {
        using (StreamWriter writer = new StreamWriter(_logFile, true))
        {
            writer.WriteLine($"[{DateTime.Now}]");
            writer.WriteLine($"Activity: {activityName}");
            writer.WriteLine($"Duration: {duration} seconds");

            writer.WriteLine("--------------------------------------------");
        }
    }

    public void DisplayLog()
    {
        Console.Clear();

        if (!File.Exists(_logFile))
        {
            Console.WriteLine("No activity logs found yet.");
        }
        else
        {
            string log = File.ReadAllText(_logFile);
            Console.WriteLine("=== Activity Log ===\n");
            Console.WriteLine(log);
        }

        Console.WriteLine("\nPress enter to return to the menu ");
        Console.ReadLine();
    }
}