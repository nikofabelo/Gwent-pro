namespace Backend;

class Board
{
	private Deck deck;

	private Cemetery cemetery;

	public Board()
	{
		this.deck = new Deck();

		this.cemetery = new Cemetery();
	}

	class Grid
	{
		private Row[] rows;

		private Grid(Row[] rows)
		{
			this.rows = rows;
		}
	}

	class Row
	{
		private Card[] cards;

		private Row(Card[] cards)
		{
			this.cards = cards;
		}
	}
}