namespace Backend;

class Card
{
	private string name;

	private Faction faction;

	private enum Faction
	{
		NEUTRAL
	}

	public Card(string name)
	{
		this.name = name;
	}

	private string Name
	{
		get
		{
			return this.name;
		}

		set
		{
			this.name = value;
		}
	}
}