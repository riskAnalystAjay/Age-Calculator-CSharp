using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== AGE CALCULATOR =====\n");

            // Step 1: Ask for user's birth date
            Console.Write("Enter your birth year (YYYY): ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter your birth month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter your birth day (1-31): ");
            int day = int.Parse(Console.ReadLine());

            // Step 2: Get today's date
            DateTime today = DateTime.Now;
            DateTime birthDate = new DateTime(year, month, day);

            // Step 3: Calculate age
            int age = today.Year - birthDate.Year;

            // Adjust if birthday hasn't come yet this year
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            // Step 4: Show result
            Console.WriteLine($"\nYour Age is: {age} years old.");

            // Extra: Show full details
            TimeSpan difference = today - birthDate;
            Console.WriteLine($"That's {difference.Days} days or {(difference.Days / 365.25):F1} years (approx).");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}