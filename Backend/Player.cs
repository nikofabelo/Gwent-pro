namespace Backend;

class Player
{
	private Deck deck;

	private Hand hand;

	public Player()
	{
		this.deck = new Deck();

		this.hand = new Hand();
		this.hand.Grab(10);
	}
}