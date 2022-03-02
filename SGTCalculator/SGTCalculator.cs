namespace SGTCalculator // Note: actual namespace depends on the project name.
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

            // Variant 4. Lorianda
            // 5a - 3b + c^7 - x | a=6, b=4, c=2, x=1.15
            varA = 6;
            varB = 4;
            varC = 2;
            varX = 1.15;

            result = 5 * varA - 3 * varB + Math.Pow(varC, 7) - varX;
            Console.WriteLine("Variant 4. Lorianda.");
            Console.WriteLine(result);
            
          
            // Next Variants should goc below this line
            
            // Variant 5. Greta K.
            // 9a + sqrt(2b) - c | a = 7, b = 26, c = 16

            varA = 7;
            varB = 26;
            varC = 16;
            result = 9 * varA + Math.Sqrt(2 * varB) - varC;
            Console.WriteLine($"Variant 5. Greta K. \n{result}");

            // Next Variants should goc below this line

            // Variant 11. Ieva P.
            // 7a + 12.5b + x +5y | a=5, b=1, x=7.01, y=3

            varA = 5;
            varB = 1;
            varX = 7.01;
            varY = 3;

            result = 7 * varA + 12.5 * varB + varX + 5 * varY;
            Console.WriteLine("Variant 11.Ieva P.");
            Console.Write(result);
         
            // Next Variants should go below this line
            
            // Variant 16. Olga S.
            // 5a - 3b + c ^ 7 - x
            // a = 6, b = 4, c = 2, x = 1.15
        
            varA = 6;
            varB = 4;
            varC = 2;
            varX = 1.15;

            result = 5 * varA - 3 * varB + Math.Pow(varC, 7) - varX;

            Console.WriteLine();
            Console.WriteLine("Variant 16. Olga S.");
            Console.WriteLine(result);
                   
            // Next Variants should go below this line
            
            // Variant 17. Indre
            // 9a + sqrt(2b) - c | a = 7, b = 26, c = 16

            varA = 7;
            varB = 26;
            varC = 16;

            result = 9 * varA + Math.Sqrt(2 * varB) - varC;
            Console.WriteLine("Variant17. Indre");
            Console.WriteLine(result);
         
            // Next Variants should go below this line
            
            // Variant 21. Valerijs D.
            // 9a + sqrt(2b) -c | a=7, b=26, c=16 

            varA = 7;
            varB = 26;
            varC = 16;

            result = 9 * varA + Math.Sqrt(2 * varB) - varC;
            Console.WriteLine("Variant 21. Valerijs D.");
            Console.WriteLine(result);

            
            // Next Variants should goc below this line
            // Variant 9. Julija N.
            // 9a + sqrt(2b) -c | a=7, b=26, c=16

            varA = 7;
            varB = 26;
            varC = 16;

            result = 9 * varA + Math.Sqrt(2 * varB) - varC;
            Console.WriteLine("Variant 9. Julija N.");
            Console.WriteLine(result);

                   
            // Next Variants should go below this line
            
            //22.Extra if wanted Zane
            //2a + 3 * b - x ^ 2 | a = 7, b = 2, x = 1.55

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


