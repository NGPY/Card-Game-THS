namespace CardGame
{
    class Player
    {
        private string name;
        private int score;

        public Player(string givenName) // Constructor
        {
            this.name = givenName;
            this.score = 0;
        }

    }
    class PlayingCard
    {
        private string suite;
        private int value;
        private string rank;

        public PlayingCard(string suite, string rank, int value)
        {
            this.suite = suite;
            this.value = value;
            this.rank = rank;
        }
    }
    class Deck
    {
        private PlayingCard[] cards = new PlayingCard[52];
        private string[] suits = { "clubs", "diamonds", "hearts", "spades" };
        private string[] ranks = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
        private int[] values = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        public Deck()
        {
            int cardNumber = 0;
            for (int i = 0; i == 4; i++)
            {
                for (int j = 0; j == 13; j++)
                {
                    cards[cardNumber] = new PlayingCard(suits[i], ranks[j], values[j]);
                    cardNumber++;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name");
            string PlayerName = Console.ReadLine();
            Player gamePlayer = new Player(PlayerName);
            string PlayerName1 = Console.ReadLine();
            Player DooDoo = new Player(PlayerName1);
        }
    }
}