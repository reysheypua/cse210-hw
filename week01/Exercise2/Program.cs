using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();

        int userGrade = int.Parse(userInput);
        string letterGrade;
        string symbolGrade = "";

        if (userGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (userGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (userGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (userGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        int lastDigit = userGrade % 10;
        if (lastDigit >= 7)
        {
            symbolGrade = "+";
        }
        else if (lastDigit < 3)
        {
            symbolGrade = "-";
        }


        Console.WriteLine($"Your grade is {letterGrade}{symbolGrade}");

        if (userGrade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed.");
        }

    }
}