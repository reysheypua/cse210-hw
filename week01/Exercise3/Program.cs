using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string again = "Y";

        while (again == "Y")
        {
            int userGuess = -100;
            int count = 0;

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                count += 1;

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! Number of tries: {count}");
                }
            }
        Console.Write("Would you like to play again? Y/N: ");
        again = Console.ReadLine().ToUpper();
        }
    }
}