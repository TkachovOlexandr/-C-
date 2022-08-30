using PlayingCard;

Stack<Card> cards = new Stack<Card>();

cards.Push(new Card(new Hearts(), "7"));
cards.Push(new Card(new Hearts(), "8"));
cards.Push(new Card(new Hearts(), "9"));
cards.Push(new Card(new Clubs(), "Queen"));
cards.Push(new Card(new Clubs(), "King"));
cards.Push(new Card(new Clubs(), "6"));
cards.Push(new Card(new Diamonds(), "10"));
cards.Push(new Card(new Diamonds(), "9"));
cards.Push(new Card(new Diamonds(), "8"));
cards.Push(new Card(new Spades(), "Ace"));
cards.Push(new Card(new Spades(), "Jack"));
cards.Push(new Card(new Spades(), "6"));

foreach (var item in cards)
    Console.WriteLine(item.ToString());