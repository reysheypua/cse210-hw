/*
I added a gamification feature to the code by making a new file named LevelInfo.cs where the level info, or the title of the user
is stored inside the class file and be calculate and have the title of the user e.g. Novice be displayed according to their
score. This will help make the program more engaging to use and complete the tasks that the user will put.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}