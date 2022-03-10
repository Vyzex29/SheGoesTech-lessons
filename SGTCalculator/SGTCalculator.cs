Console.WriteLine("Enter first number");
string number1string = Console.ReadLine();
int number1Parse = int.Parse(number1string);

Console.WriteLine("Enter second number");
string number2string = Console.ReadLine();
int number2Parse = int.Parse(number2string);

var result1 = number1Parse + number2Parse;
var result2 = number1Parse - number2Parse;
var result3 = number1Parse / number2Parse;
var result4 = number1Parse * number2Parse;
var result5 = number1Parse % number2Parse;



char symbol = '+';
Console.WriteLine("Enter one of the symbols for calculation: +, -, /, *, %, p, b, s");
string symbolString = Console.ReadLine();
bool symbolParsed = char.TryParse(symbolString, out symbol);

switch (symbol)
{
    case '+':
        Console.WriteLine($"Sum of both elements: {result1}");
        break;
    case '-':
        Console.WriteLine($"Subtraction: {result2}");
        break;
    case '/':
        Console.WriteLine($"Division: {result3}");
        break;
    case '*':
        Console.WriteLine($"Multiplication: {result4}");
        break;
    case '%':
        Console.WriteLine($"Remainder: {result5}");
        break;
    case 'p':
        Console.WriteLine($"Number1 is {number1Parse}, Number2 is {number2Parse}");
        break;
    case 'b':
        if (number1Parse > number2Parse)
        {
            Console.WriteLine("Number1 is bigger than Number2");
        }
        else
        {
            Console.WriteLine("Number2 is bigger than Number1");
        }
        break;
    case 's':
        if (number1Parse < number2Parse)
        {
            Console.WriteLine("Number1 is smaller than Number2");
        }
        else
        {
            Console.WriteLine("Number2 is smaller than Number1");
        }
        break;
}
