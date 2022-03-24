using System.Text;

namespace SGTCalculator 
{
    public enum Suits
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds
    }

    public enum CardValues
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class SGTCalculator
    {

        static public void Shuffle(string[] cardPack)
        {
            Random rnd = new Random();

            for (int n = cardPack.Length - 1; n > 0; --n)
            {
                int k = rnd.Next(n + 1);
                string temp = cardPack[n];
                cardPack[n] = cardPack[k];
                cardPack[k] = temp;
            }
        }

        static void Main(string[] args)
        {
            string[] cardPack = new string[52];

            int position = 0;
            foreach (string suit in Enum.GetNames(typeof(Suits)))
            {
                foreach (string values in Enum.GetNames(typeof(CardValues)))
                {
                    cardPack[position] = $"{values} of {suit}";
                    position++;
                }
            }
            Console.WriteLine($"The first card is {cardPack[0]}");

            Shuffle(cardPack);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{cardPack[i]}");
            }
            

        }
    }
}


