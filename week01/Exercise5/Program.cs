using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqnum = SquareNumber(number);
        DisplayResult(name, sqnum);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumberStr = Console.ReadLine();
            int userNumber = int.Parse(userNumberStr);
            return userNumber;
        }

        static int SquareNumber(int num)
        {
            int squarenum = num * num;
            return squarenum;
        }
        
        static void DisplayResult(string username, int sqnum)
        {
            Console.WriteLine($"{username}, the square of your number is {sqnum}");
        }
    }
}