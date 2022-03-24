using System;

namespace SGTCalculator 
{

    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            // ISO8601 yyyy-MM-dd
            Console.WriteLine("Enter the day of your birthday!");
            string day = Console.ReadLine();

            Console.WriteLine("Enter the month of your birthday!");
            string month = Console.ReadLine();

            Console.WriteLine("Enter the year of your birthday!");
            string year = Console.ReadLine();

            string forParsing = $"{year}-{month}-{day}";
            Console.WriteLine(DateTime.Parse(forParsing).ToString("yyyy-MM-dd"));
        }
    }
}


