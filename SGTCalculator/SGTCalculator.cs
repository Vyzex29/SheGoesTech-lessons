using SGTCalculator;
using System.Text.RegularExpressions;

Literature book = new Literature();
book.Title = "Unknown";

/*string bookInformation = book.GetLiteratureInfo();

var result = Math.Pow(2, 5);

Regex regex = new Regex("[a-zA-Z]");
if (regex.IsMatch(bookInformation))
{
    Console.WriteLine("Book matches our guidelines");
}

Console.WriteLine($"From method GetLiteratureInfo: {bookInformation}");
book.PrintLiteratureInfo();*/

Fiction fiction = new Fiction();
fiction.Title = "Dragon Slayer";
fiction.Genre = "Fantasy";

NonFiction nonFiction = new NonFiction();
nonFiction.Title = "OpevCV2 library review";
nonFiction.PeerReviewed = false;

List<Literature> library = new List<Literature>();
library.Add(book);
library.Add(nonFiction);
library.Add(fiction);

// Library showcase
foreach (Literature literature in library)
{
    literature.PrintLiteratureInfo();
}
book.PrintLiteratureInfo(DateTime.Now);