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
            // Variant 11. Ieva P.
            // 7a + 12.5b + x +5y | a=5, b=1, x=7.01, y=3

            varA = 5;
            varB = 1;
            varX = 7.01;
            varY = 3;

            result = 7 * varA + 12.5 * varB + varX + 5 * varY;
            Console.WriteLine("Variant 11.Ieva P.");
            Console.Write(result);
        }
    }
}