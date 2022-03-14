namespace SGTCalculator // Note: actual namespace depends on the project name.
{
    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            /*
            int[] intArray = new int[3];

            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;

            Console.WriteLine($"The values of the array are:" +
                $" {intArray[0]}, {intArray[1]}, {intArray[2]} ");

            int[] temperatures = {24,23,22,15,17,18,19};
            int lastElementValue = temperatures[temperatures.Length - 1];
            Console.WriteLine($"LastElementOfTheArray is {lastElementValue}");
            //Console.WriteLine($"Temperature on Sunday is {temperatures[6]}");

            int sumOfElements = 0;
            double averageTemparature;

            for (int i = 0; i < temperatures.Length; i++)
            {
                sumOfElements += temperatures[i];
            }

            int counter = 1;
            foreach (int temperature in temperatures)
            {
                Console.WriteLine($"Temperatures for this week, Day {counter}: {temperature}");
                counter++;
            }

            averageTemparature = (double)sumOfElements / (double)temperatures.Length;

            Console.WriteLine($"The average temperature for the week is {averageTemparature} C");

            */
            /*
            for (int i=7; i < 10; i++) 
            {
                Console.WriteLine($"It is the {i} iteration");
            }*/
            
            /* infinite loop
            for (int i = 0; i < 10; i--) 
            {
                Console.WriteLine($"It is the {i} iteration");
            }
            */
            /*
            var amountSpent = 0;

            for(int i = 0; i < 100; i++)
            {
                if(i % 7 == 0)
                {
                    Console.WriteLine("You get a free coffe!");
                }
                else
                {
                    Console.WriteLine("You pay 3 euro for coffe");
                    amountSpent += 3;
                }
            }

            Console.WriteLine($"We spent on coffe {amountSpent} euros");
            */

            var rand = new Random();
            var wakeUpAttempts = 0;
            var wakeUpAttemptsLimit = rand.Next(0,5);
            float time = 7.5f;
            Console.WriteLine($"Wake up atempts limit is {wakeUpAttemptsLimit}");

            while (true)
            {
                Console.WriteLine($"Alarm is sounding, it's {time} o' clock, WAKE UP");
                Console.WriteLine($"Valera pressed the snoozed button, ZZZZ");
                time += 0.5f;
                wakeUpAttempts++;
                if (wakeUpAttempts == wakeUpAttemptsLimit)
                {
                    break;
                }
            }

            Console.WriteLine($"Valera has woken up at {time} o'clock");

        }
    }
}


