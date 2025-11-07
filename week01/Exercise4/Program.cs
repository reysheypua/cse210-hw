using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        bool ongoing = true;
        List<int> numbers = new List<int>();
        int sum = 0;
        int largerstnum = -1000000000;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (ongoing == true)
        {
            Console.Write("Enter a number: ");
            string userNumberInput = Console.ReadLine();
            int userNumber = int.Parse(userNumberInput);

            if (userNumber == 0)
            {
                ongoing = false;
            }
            else
            {
                numbers.Add(userNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
            if (largerstnum < number)
            {
                largerstnum = number;
            }
        }

        float avg = (float)sum / numbers.Count();

        List<int> newNumbers = new List<int>();
        while (numbers.Count() > 0)
        {
            int smallestnum = 1000000000;
            foreach (int number in numbers)
            {
                if (smallestnum > number)
                {
                    smallestnum = number;
                }
            }

            newNumbers.Add(smallestnum);
            numbers.Remove(smallestnum);
        }


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largerstnum}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in newNumbers)
        {
            Console.WriteLine(number);
        }
    }
}