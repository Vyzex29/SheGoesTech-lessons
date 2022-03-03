namespace SGTCalculator // Note: actual namespace depends on the project name.
{
    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            
            // Parsing - assumes the string passed is always filled with the correct corresponding data type values 
            // Convert - assumes the string passed is always filled with the correct corresponding data type values,
            //but when passed null, will return 0
            // TryParse - Wil check whether the entered string is valid, if it;s valid will return the value and return a boolean value
            // telling that the string entered is convertable. If the string is not valid will assign default value to the number and return a false boolean value
            Console.WriteLine("Enter first number!");

            string number1string = Console.ReadLine();

            //double number1Parse = double.Parse(number1string);
            //double number1Convert = Convert.ToDouble(number1string);
            bool num1IsParsed = double.TryParse(number1string, out double number1Tryparse);
            Console.WriteLine("Enter second number!");

            string number2string = Console.ReadLine();

            //double number2Parse = double.Parse(number2string);
            //double number2Convert = Convert.ToDouble(number2string);
            bool num2IsParsed = double.TryParse(number2string, out double number2Tryparse);
            double sum = number1Tryparse / number2Tryparse;

            Console.WriteLine($"The sum between {number1Tryparse} and {number2Tryparse} is: {sum}");
            Console.WriteLine($"Is the first number parsable: {num1IsParsed} \n Is the second number parsable: {num2IsParsed}");


        }
    }
}


