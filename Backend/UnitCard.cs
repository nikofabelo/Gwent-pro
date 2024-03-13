namespace Backend;

delegate void SkillMethod();

class UnitCard : Card
{
	private enum Type
	{
		GOLD,
		SILVER
	}

	public class UnitCard(Type type)
	{
		//
	}

	public SkillMethod Skill
	{
		get; set;
	}
}