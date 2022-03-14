namespace SGTCalculator // Note: actual namespace depends on the project name.
{
    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            double[,] array2d = new double[3,5];

            var random = new Random();
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for(int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i,j] = Math.Round(random.NextDouble() * 1000, 2);
                }
            }

            double sumOfRow = 0;

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write($"|{array2d[i, j]}| ");
                    sumOfRow += array2d[i, j];
                }
                Console.Write($" = {sumOfRow}");
                sumOfRow = 0;
                Console.WriteLine();
            }



            double sumOfElements = 0;

            foreach (double element in array2d)
            {
                sumOfElements += element;
            }

            Console.WriteLine($"Sum of elements of the array is {sumOfElements}");
        }
    }
}


