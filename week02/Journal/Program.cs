using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool ongoing = true;

        while (ongoing)
        {
            Console.WriteLine("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string userTextEntry = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._promptText = prompt;
                newEntry._entryText = userTextEntry;
                newEntry._date = DateTime.Now.ToShortDateString();
                journal.AddEntry(newEntry);

                Console.WriteLine("Would you like your daily quote of the day? Y/N: ");
                string quoteChoice = Console.ReadLine().ToUpper();
                if (quoteChoice == "Y")
                {
                    QuoteGenerator quoteGenerator = new QuoteGenerator();
                    string quote = quoteGenerator.GetRandomQuote();
                    Console.WriteLine($"\n{quote}");
                }
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }

            else if (choice == "5")
            {
                ongoing = false;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please input a valid number of your choice.");
            }
        }
    }
}