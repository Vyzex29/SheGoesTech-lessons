
using System.Text.RegularExpressions;

namespace SGTCalculator 
{
    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            string[] cities = { "Copenhagen", "Paris", "Tokyo", "Bristol",
                "Mumbai", "Delhi", "Riga", "Vienna", "Warsaw", "Hamburg", "Cesis" };
            int[] cityLength = new int[cities.Length];

            Regex re = new Regex("^C", RegexOptions.IgnoreCase);
            int cCount = 0;
            Regex re2 = new Regex("i$", RegexOptions.IgnoreCase);
            int iCount = 0;
            int count5Letters = 0;
            Regex re3 = new Regex("[*e]", RegexOptions.IgnoreCase);
            int eCount = 0;
            Regex re4 = new Regex("(en)");
            int enCount = 0;

            for (int i = 0; i < cities.Length; i++)
            {
                if (re.IsMatch(cities[i]))
                {
                    cCount++;
                    Console.WriteLine($"Starts with C: {cities[i]}");
                }
                /*
                 if(cities[i][cities[i].Length-1] == 'i')
                 {
                    Console.WriteLine(cities[i]);
                 }
                 */
                if (re2.IsMatch(cities[i]))
                {
                    iCount++;
                    Console.WriteLine($"Ends with i: {cities[i]}");
                }
                if (cities[i].Length == 5)
                {
                    count5Letters++;
                    Console.WriteLine($"Length is 5: {cities[i]}");
                }
                if (re3.IsMatch(cities[i]))
                {
                    eCount++;
                    Console.WriteLine($"Contains e: {cities[i]}");
                }
                /*if (cities[i].IndexOf('e') != -1)
                {
                    eCount++;
                    Console.WriteLine($"Contains e: {cities[i]}");
                }*/
                if (re4.IsMatch(cities[i]))
                {
                    enCount++;
                    Console.WriteLine($"Contains en: {cities[i]}");
                }
                cityLength[i] = cities[i].Length;
            }
            Console.WriteLine($"City count starting with letter \"C\": {cCount}");
            Console.WriteLine($"City count ending with letter \"i\": {iCount}");
            Console.WriteLine($"City count with length 5 : {count5Letters}");
            Console.WriteLine($"City count contains \"e\" : {eCount}");
            Console.WriteLine($"City count contains \"en\" : {enCount}");


            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"{cities[i]} = {cityLength[i]}");
            }


            Console.WriteLine("Enter letter");
            char.TryParse(Console.ReadLine(), out char userInput);

            var regex = new Regex($"^{userInput}");

            for (int i = 0; i < cities.Length; i++)
            {
                if (regex.IsMatch(cities[i]))
                {
                    Console.WriteLine($"Matches with user input {userInput}: {cities[i]}");
                }
            }

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i][0] == userInput)
                {
                    Console.WriteLine($"Matches with user input {userInput}: {cities[i]}");
                }
            }
        }
    }
}


