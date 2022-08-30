namespace PlayingCard
{
    internal class Card
    {
        private string suitName;
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }


        public string SuitName
        {
            get { return suitName; }
            set { suitName = value; }
        }

        public Card(Suit suit, string number)
        {
            SuitName = suit.Name;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number} of {SuitName}";
        }

    }
}
