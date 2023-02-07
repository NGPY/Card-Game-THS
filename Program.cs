namespace CardGame
{
    class Player
    {
        // Properties
        private string name;
        private int score;
        // Constructors
        public Player(string givenName)
        {
            this.name = givenName;
            this.score = 0;
        }
        // Getters and Setters
        public string Name { get { return name; } }
        public int Score { get { return score; } set { score = value; } }


    }
    class PlayingCard
    {
        // Properties
        private string suite;
        private int value;
        private string rank;
        // Constructor
        public PlayingCard(string suite, string rank, int value)
        {
            this.suite = suite;
            this.value = value;
            this.rank = rank;
        }
        // Getters and Setters
        public string Suite { get { return suite; } }
        public int Value { get { return value; } }
        public string Rank { get { return rank; } }
    }
    class Deck
    {
        // Properties
        private PlayingCard[] cards = new PlayingCard[52];
        private string[] suits = { "clubs", "diamonds", "hearts", "spades" };
        private string[] ranks = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
        private int[] values = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        // Constructor
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
        // Getters and setters
        public PlayingCard[] Cards { get { return cards; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard queen = new PlayingCard("hearts", "queen", 10);
            Console.WriteLine(queen.Rank);
        }
    }
}