namespace SGTCalculator
{
    internal class NonFiction : Literature
    {
        public bool PeerReviewed { get; set; }

        public string Field { get; set; }

        public List<string> ListOfReferences { get; set; }

        public override void PrintLiteratureInfo()
        {
            base.PrintLiteratureInfo();
            Console.WriteLine($", Field: {Field}, IsPeerReviewed: {PeerReviewed}");
        }
    }
}
