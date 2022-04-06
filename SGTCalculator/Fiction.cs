namespace SGTCalculator
{
    internal class Fiction : Literature
    {
        public string Genre { get; set; }

        public override void PrintLiteratureInfo()
        {
            base.PrintLiteratureInfo();
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}
