using System;

namespace EnumExample
{
    // Define an enum to represent the days of the week
    public enum DaysOfWeek
    {
        Sunday,    // Represents Sunday
        Monday,    // Represents Monday
        Tuesday,   // Represents Tuesday
        Wednesday, // Represents Wednesday
        Thursday,  // Represents Thursday
        Friday,    // Represents Friday
        Saturday   // Represents Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Assign an enum value to a variable
            DaysOfWeek today = DaysOfWeek.Monday;

            // Print the enum value
            Console.WriteLine("Today is: " + today); // Output: Today is: Monday

            // Convert the enum value to its corresponding integer value
            int dayNumber = (int)today;
            Console.WriteLine("Day number is: " + dayNumber); // Output: Day number is: 1

            // Parse a string to an enum value safely using Enum.TryParse
            if (Enum.TryParse("Friday", out DaysOfWeek parsedDay))
            {
                Console.WriteLine("Parsed day is: " + parsedDay); // Output: Parsed day is: Friday
            }
            else
            {
                Console.WriteLine("Invalid day string provided.");
            }
        }
    }
}