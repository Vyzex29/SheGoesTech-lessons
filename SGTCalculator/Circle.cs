namespace SGTCalculator
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public override void CalculateArea()
        {
            Console.WriteLine($"The circle area is {Math.Round(Radius * Math.PI * 2, 2)}");
        }
    }
}
