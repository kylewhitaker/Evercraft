public class Abilities
{
	public static readonly int MIN = 1;
	public static readonly int MAX = 20;

	private int charisma;
	public int Charisma
	{
		get
		{
			return charisma;
		}
		set
		{
			if (value < MIN) charisma = MIN;
			else if (value > MAX) charisma = MAX;
			else charisma = value;
		}
	}

	private int constitution;
	public int Constitution
	{
		get
		{
			return constitution;
		}
		set
		{
			//constitution = value < MIN ? MIN : value > MAX ? MAX : value;
			if (value < MIN) constitution = MIN;
			else if (value > MAX) constitution = MAX;
			else constitution = value;
		}
	}

	public int Dexterity { get; set; }
	public int Intelligence { get; set; }
	public int Strength { get; set; }
	public int Wisdom { get; set; }

	public Abilities()
	{
		const int TEN = 10;
		Charisma = TEN;
		Constitution = TEN;
		Dexterity = TEN;
		Intelligence = TEN;
		Strength = TEN;
		Wisdom = TEN;
	}
}