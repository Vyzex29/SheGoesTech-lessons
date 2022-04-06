namespace SGTCalculator
{
    internal class Literature
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public int ID { get; set; }

        public virtual string GetLiteratureInfo()
        {
            string literatureString = $"Id: {ID}, Title: {Title}, Author: {Author}";

            return literatureString;
        }

        public virtual void PrintLiteratureInfo()
        {
            Console.WriteLine($"Id: {ID}, Title: {Title}, Author: {Author}");
        }

        public virtual void PrintLiteratureInfo(DateTime timestamp) 
        {
            Console.WriteLine($"Requested at {timestamp}\n Id: {ID}, Title: {Title}, Author: {Author}");
        }

        public virtual void PrintLiteratureInfo(string str)
        {
            Console.WriteLine($"{str}\n Id: {ID}, Title: {Title}, Author: {Author}");
        }
    }
}
