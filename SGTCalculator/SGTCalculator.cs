using System.Text.RegularExpressions;

namespace SGTCalculator 
{

    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to see if it's a palindrome");
            string userInput = Console.ReadLine().ToLower();

            string userInputFormated = string.Empty;
            Regex re = new Regex("[a-zA-Z]");
            for (int i = 0; i < userInput.Length; i++)
            {
                if (re.IsMatch(userInput[i].ToString()))
                {
                    userInputFormated += userInput[i];
                }
            }

            string userInputReversed = string.Empty;
            bool isPalindrome;
            for (int i = userInputFormated.Length-1; i >= 0; i--)
            {
                userInputReversed += userInputFormated[i];
            }

            isPalindrome = userInputFormated.Equals(userInputReversed);
            Console.WriteLine(userInputReversed);
            Console.WriteLine($"You have entered a palindrome: {isPalindrome}");
        }
    }
}


