using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");

        Running running = new Running(new DateTime(2025, 06, 23), 60, 5.0);
        Cycling cycling = new Cycling(new DateTime(2025, 09, 07), 45, 10.0);
        Swimming swimming = new Swimming(new DateTime(2025, 11, 18), 23, 12);

        List<FitnessCenter> fitnessCenters = new List<FitnessCenter>();
        fitnessCenters.Add(running);
        fitnessCenters.Add(cycling);
        fitnessCenters.Add(swimming);

        foreach (FitnessCenter fitnessCenter in fitnessCenters)
        {
            Console.WriteLine(fitnessCenter.GetSummary());
        }
    }
}