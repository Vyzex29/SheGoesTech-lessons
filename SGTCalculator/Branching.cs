namespace SGTCalculator
{
    public class Branching
    {
        public enum Names {
            Valera,
            Andrew
        }

        public void Demo()
        {
            int number = 10;
            bool condition1 = false;
            bool condition2 = true;
            if (number % 2 == 0) // if condition is true, execute then execute the scope below
            {
                Console.WriteLine($"{number} is even");
            }
            else // if condition is false execute the else statement
            {
                Console.WriteLine($"{number} is false");
            }


            if (condition1) // if else if , if first condition is false then chech the next else if conditon
            {

            }else if (condition2)
            {

            }

            string str = "abc";

            if (str == "ab")
            {
                if (str.Length == 2) // you can have if inside if statement
                {

                }
            } else if (str == "acb")
            {

            }else if (str == "abc")
            {

            }

            string switchKey = "abc"; // switch can strings, char, numerical, enum values as key

            switch (switchKey)
            {
                case "abc":
                    Console.WriteLine("entered abc");
                    break;
                case "acb":
                    Console.WriteLine("entered acb");
                    break;
                case "bac":
                    Console.WriteLine("entered bac");
                    break;
                case "cab":
                    Console.WriteLine("entered cab");
                    break;
                default:
                    Console.WriteLine("nothing matches");
                    break;
            }
        }
    }
}
