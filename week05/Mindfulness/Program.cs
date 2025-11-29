using System;

/*
For Creativity and Exceeding Requirements, I have added a log file for each session that the user has done. Even when the program would
close, the save file will still be there as it is stored inside a .txt file. I used a log manager file to manage the saving of data
and the display of the log data into the console. Not only did I put the log data of the user but also put the date and time of when
the session was created and logged.
*/

class Program
{
    static void Main(string[] args)
    {
        bool ongoing = true;

        while (ongoing)
        {
            Console.Clear();

            Console.WriteLine("Hello World! This is the Mindfulness Project.\n");

            Console.Write("Menu Options:\n"+
                "   1. Start breathing activity\n"+
                "   2. Start reflecting activity\n"+
                "   3. Start listing activity\n"+
                "   4. View activity log\n"+
                "   5. Quit\n"+
                "Select a choice from the menu: ");

            string menuChoice = Console.ReadLine().Trim();

            if (menuChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

                breathingActivity.Run();
            }
            else if (menuChoice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
                reflectingActivity.Run();
            }
            else if (menuChoice == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                listingActivity.Run();
            }
            else if (menuChoice == "4")
            {
                LogManager logManager = new LogManager();
                logManager.DisplayLog();
            }
            else
            {
                ongoing = false;
            }
        }

    }
}