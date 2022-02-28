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
            // Variant 20. Renate V.
            // 5a - 3b + c^7 - x | a=6, b=4, c=2, x=1.15

            varA = 6;
            varB = 4;
            varC = 2;
            varX = 1.15;

            result2 = 5 * varA – 3 * varB + Math.Pow(varC, 7) – varX;
            Console.WriteLine("Variant 20. Renate V." /n);
            Console.WriteLine(result2);


            // Variant 21. Valerijs D.
            // 9a + sqrt(2b) -c | a=7, b=26, c=16 

            varA = 7;
            varB = 26;
            varC = 16;

            result = 9 * varA + Math.Sqrt(2 * varB) - varC;
            Console.WriteLine("Variant 21. Valerijs D.");
            Console.WriteLine(result);
        }
    }
}

//Variant 3. Violeta 
//7a + 12.5b + x +5y | a=5, b=1, x=7.01, y=3 

varA = 5;
varB = 1;
varX = 7.01;
varY = 3;

result = 7 * varA + 12.5 * varB + Math.Pow(varX) + 5 * varY;
Console.WriteLine("Variant 3. Violeta");
Console.WriteLine(result); 


