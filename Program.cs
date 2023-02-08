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
        private int value; // googoo
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
            Circle goo = new Circle(31.4);
            (string, double) q = goo.GenerateCircumferanceQuestion();
            Console.WriteLine(q.Item1);
            double answer = Convert.ToDouble(Console.ReadLine());
            if (answer == q.Item2)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
                Console.WriteLine($"Correct answer: {q.Item2}");
            }

        }
    }
    // circle

    class Circle
    {
        private double pi = 3.14;
        public double radius { get; }
        public double diameter { get; }
        public double area { get; }
        public double circumferance { get; }

        public Circle(double radius)
        {
            this.radius = Math.Round(radius, 2);
            this.circumferance = Math.Round(radius * pi * 2, 2);
            this.area = Math.Round(pi * Math.Pow(radius, 2), 2);
            this.diameter = Math.Round(radius * 2, 2);
        }
        public (string, double) GenerateAreaQuestion()
        {
            return ($"Find the area of a circle with a radius of {this.radius} ", 3.14 * Math.Pow(this.radius, 2));
        }
        public (string, double) GenerateCircumferanceQuestion()
        {
            return ($"Find the radius of a circle with circumferance of {this.circumferance}", this.radius);
        }
    }

}