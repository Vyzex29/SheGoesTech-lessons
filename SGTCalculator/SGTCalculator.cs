﻿namespace SGTCalculator // Note: actual namespace depends on the project name.
{
    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            // Define variables
            int varA, varB, varC;
            double varX, varY, varZ;
            double result;

            // Variant 1. Valerijs D.
            // a^3 + 5*b + sqrt(x)
            // a = 7, b = 95, x = 179.62
            varA = 7;
            varB = 95;
            varX = 179.62;

            result = Math.Pow(varA, 3) + 5 * varB + Math.Sqrt(varX);
            Console.WriteLine("Variant 1. Valerijs D.");
            Console.WriteLine(result);


            // Next Variants should goc below this line
            // Variant 21. Valerijs D.
            // 9a + sqrt(2b) -c | a=7, b=26, c=16 

            varA = 7;
            varB = 26;
            varC = 16;

            result = 9 * varA + Math.Sqrt(2 * varB) - varC;
            Console.WriteLine("Variant 21. Valerijs D.");
            Console.WriteLine(result);

            //22.Extra if wanted. 2a + 3 * b - x ^ 2 | a = 7, b = 2, x = 1.55

            varA = 7;
            varB = 2;
            varX = 1.55;

            result = 2 * varA + 3 * varB - Math.Pow(varX, 2);
            Console.WriteLine("Variant 22. Zane");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}