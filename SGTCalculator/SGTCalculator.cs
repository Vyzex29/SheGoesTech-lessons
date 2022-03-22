using System.Text.RegularExpressions;

namespace SGTCalculator
{
    public class SGTCalculator
    {
        static void Main(string[] args)
        {


            Console.WriteLine("=======================================");

            /* A.*s -- Ananass
              ^ StartsWith --> mathch StartsWithThisSentence
              Contains only from alphanumeric a-z (lower case only)
              [a-z]+ one or more times
                \d == [0-9]
            */

            // validate this range: 1900 - 2100

            string validInput = "2020";
            string invalidInput = "199029";

            // build a pattern to validate a year
            var reg = new Regex("^\\d\\d\\d\\d$"); // either double slash or @

            if (reg.IsMatch(validInput))
            {
                Console.WriteLine($"{validInput} is valid year");
            }
            else
            {
                Console.WriteLine($"{validInput} is not a valid year");
            }

            if (reg.IsMatch(invalidInput))
            {
                Console.WriteLine($"{invalidInput} is valid year");
            }
            else
            {
                Console.WriteLine($"{invalidInput} is not a valid year");
            }

            // but this allows 2999
            var regImprovement = new Regex("^[1-2]{1}[019]{1}\\d\\d$");

            Console.WriteLine("=======Enhanced validation rules=====");
            if (regImprovement.IsMatch(validInput))
            {
                Console.WriteLine($"{validInput} is valid year");
            }
            else
            {
                Console.WriteLine($"{validInput} is not a valid year");
            }

            if (regImprovement.IsMatch(invalidInput))
            {
                Console.WriteLine($"{invalidInput} is valid year");
            }
            else
            {
                Console.WriteLine($"{invalidInput} is not a valid year");
            }

            var regImprovementNext = new Regex("^(19|20)\\d\\d$");
            Console.WriteLine("=======Enhanced validation rules V2=====");
            if (regImprovementNext.IsMatch(validInput))
            {
                Console.WriteLine($"{validInput} is valid year");
            }
            else
            {
                Console.WriteLine($"{validInput} is not a valid year");
            }

            if (regImprovementNext.IsMatch(invalidInput))
            {
                Console.WriteLine($"{invalidInput} is valid year");
            }
            else
            {
                Console.WriteLine($"{invalidInput} is not a valid year");
            }

            var regImprovementFinal = new Regex("^((19|20)\\d\\d|2100)$"); // grouping
            Console.WriteLine("=======Final validation rules=====");
            if (regImprovementFinal.IsMatch(validInput))
            {
                Console.WriteLine($"{validInput} is valid year");
            }
            else
            {
                Console.WriteLine($"{validInput} is not a valid year");
            }

            if (regImprovementFinal.IsMatch(invalidInput))
            {
                Console.WriteLine($"{invalidInput} is valid year");
            }
            else
            {
                Console.WriteLine($"{invalidInput} is not a valid year");
            }
        }
    }
}


