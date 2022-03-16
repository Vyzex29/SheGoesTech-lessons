namespace SGTCalculator // Note: actual namespace depends on the project name.
{
    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            double[,] array2d = new double[3,5]; // 2d array definition
            double[] sumOfColumns = new double[array2d.GetLength(1)]; // definiton of 1d Array for sum Of columns using the GetLength of columns of 2darray

            var random = new Random();
            for (int i = 0; i < array2d.GetLength(0); i++)  // nested for loop for initializing the values inside the 2dArray
            {
                for(int j = 0; j < array2d.GetLength(1); j++)
                {
                    double randomNumber = random.NextDouble();
                    array2d[i,j] = Math.Round(randomNumber * 100, 2);
                }
            }

            double sumOfRow = 0;

            for (int row = 0; row < array2d.GetLength(0); row++) //NESTED LOOP
            {
                for (int column = 0; column < array2d.GetLength(1); column++)
                {
                    Console.Write($"|{array2d[row, column]}| ");
                    sumOfRow += array2d[row, column];
                }

                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    sumOfColumns[j] += array2d[row, j];
                } 

                Console.Write($" = {sumOfRow}");
                Console.WriteLine();
                sumOfRow = 0;
            }

            foreach (var sum in sumOfColumns)
            {
                Console.Write($" {Math.Round(sum,2)} ");
            }

            double sumOfElements = 0;


            foreach (double element in array2d)
            {
                sumOfElements += element;
            }

            Console.WriteLine($"\nSum of elements of the array is {Math.Round(sumOfElements,2)}");
        }
    }
}


