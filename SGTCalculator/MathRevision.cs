namespace SGTCalculator
{
    public class MathRevision
    {
        public void Demo()
        {
            double result = 93 % 30; // 90 / 30 = 3  3 / 30 == 3 Modulo calculates remainer
            double result2 = Math.Pow(2, 10); // 2^4 2*2*2*2
            double result3 = Math.PI;
            double result4 = Math.Round(result3, 4);

            Console.WriteLine(result);
            Console.WriteLine($"2 ^ 4 = {result2}");

            Console.WriteLine($"Math Pi rounded up to 4 digits {result4}");
        }
    }
}
