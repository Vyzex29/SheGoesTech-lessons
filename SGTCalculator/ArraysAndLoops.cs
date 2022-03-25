namespace SGTCalculator
{
    public class ArraysAndLoops
    {
        public void Demo()
        {
            string[] names = new string[5];  // definition of array inside the new dataType square brackets
                                             // [] we write down the size of the array example new string[10];
                                             // array start their position from 0 
                                             // store mutliple of the same type data
            names[0] = "Valera";
            names[1] = "Anata";
            names[2] = "Andrew";
            names[3] = "George";
            names[4] = "Philip";

            int[] ages = { 20, 21, 30, 40, 12 }; // short notation definiton and inicialization

            for (int positionInArray = names.Length - 1; positionInArray >= 0 ; positionInArray--) 
                // loop will only continue when the condition is true
            {
                Console.WriteLine($"{names[positionInArray]} : {ages[positionInArray]}");
            }
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            var studentList = new List<Student>
            {
               new Student(23,"Valera"),
               new Student(21,"Ilze")
            };

            foreach (Student student in studentList)
            {
                Console.WriteLine($"{student.Name} : {student.Age}");
            }

            char[,] ticTacToe = new char[3, 3];
                                       //  0 1 2
            ticTacToe[0, 0] = 'O';     //0 O X O
            ticTacToe[0, 1] = 'X';     //1 O
            ticTacToe[0, 2] = 'O';     //2 O
            ticTacToe[1, 0] = 'O';
            ticTacToe[1, 1] = 'O';
            ticTacToe[1, 2] = 'O'; 
            ticTacToe[2, 0] = 'O';
            ticTacToe[2, 1] = 'O';
            ticTacToe[2, 2] = 'O';


            Console.WriteLine();
            for (int row = 0; row < ticTacToe.GetLength(0); row++)
            {
                for (int col = 0; col < ticTacToe.GetLength(1); col++)
                {
                    Console.Write($"{ticTacToe[row, col]} ");
                }
                Console.WriteLine();
            }

            bool condition = false;
            while (condition) // first checks the conditon and if it is true, we do the loop 
            {
                Console.WriteLine("We have done the loop!");
            }

            do  // will do atleast 1 iteration and then check whether the condition is true
            {
                Console.WriteLine("We have done the loop!");
            } while (condition);
        }
    }
}
