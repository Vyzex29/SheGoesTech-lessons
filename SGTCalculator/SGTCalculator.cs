namespace SGTCalculator // Note: actual namespace depends on the project name.
{
    public class SGTCalculator
    {
        static void Main(string[] args)
        {

            var coffeConsumptionCounter = 0;

            int[] days = new int[7];

            days[0] = 1;
            days[1] = 2;
            days[2] = 3;
            days[3] = 1;
            days[4] = 4;
            days[5] = 5;
            days[6] = 0;

            for (int i = 0; i < days.Length; i++) // i = 0; 0 < days.Length = 7; i ++|  0+1 = 1
            {
                coffeConsumptionCounter += days[i]; // 0 + days[0].value = 1
            }

            Console.WriteLine($"During the week i consumed {coffeConsumptionCounter} coffes");


            int[,] array2D = new int[3, 4]; // definition of array

            array2D[0, 0] = 14; // inicialization of specific position values
            array2D[0, 1] = 15;
            array2D[0, 2] = 16;
            array2D[0, 3] = 17;
            array2D[1, 0] = 1;

            int[,] array2D2 = { { 1, 2, 3, 4 }, { 14, 15, 16, 17 }, { 4, 5, 6, 7 } }; // shortNotation definition and initialization of 2d array



            int[,] paintArray = { { 43, 13, 12 }, { 7, -48, 152 }, { 60, 72, 7 } };
            /* printing out array from hand
            Console.WriteLine($"|{paintArray[0,0]}|{paintArray[0, 1]} |{paintArray[0, 2]} |");
            Console.WriteLine($"|{paintArray[1,0]} |{paintArray[1, 1]}|{paintArray[1, 2]}|");
            Console.WriteLine($"|{paintArray[2,0]}|{paintArray[2, 1]} |{paintArray[2, 2]}  |");
            */

            for (int row = 0; row < 3; row++) // Traversing 2d array
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.WriteLine($"we are looking at coordinate paintArray[{row},{column}] = {paintArray[row, column]}");
                }
                Console.WriteLine();
            }

            foreach (int value in paintArray)
            {
                Console.WriteLine($"The values are {value}");
            }

            // menu sample
            bool whileMenuIsRunning = true;

            Console.WriteLine($"Choose a compliment out of the menu:");
            Console.WriteLine($"1 - you are smart!");
            Console.WriteLine($"2 - you are pretty!");
            Console.WriteLine($"3 - you are the best!");
            Console.WriteLine($"4 - quit!, but you still rock");

            while (whileMenuIsRunning)
            {

                int.TryParse(Console.ReadLine(), out int menuItem);

                switch (menuItem)
                {
                    case 1:
                        Console.WriteLine("You are smart!");
                        break;
                    case 2:
                        Console.WriteLine("You are pretty!");
                        break;
                    case 3:
                        Console.WriteLine("You are the best!");
                        break;
                    case 4:
                        Console.WriteLine("Bye!");
                        whileMenuIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Unkown item, try an existing number");
                        break;
                }

            }


            int time = 25;
            do
            {
                Console.WriteLine($"It is {time} o'clock");
                time++;
            } while (time < 24);

        }
    }
}


