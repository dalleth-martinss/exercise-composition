using ExerciseComposition.Entities;
using ExerciseComposition.Entities.Enums;
using System.Globalization;
using System;
using System.Collections.Generic;


namespace ExerciseComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter departamt's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine(), true);

            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        }
    }
}
