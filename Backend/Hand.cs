namespace Backend;

class Hand
{
	public Hand()
	{
		//
	}

	public Card[] Take(Deck deck, int n)
	{
		return deck[n];
	}
}