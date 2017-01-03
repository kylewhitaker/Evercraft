public class Abilities
{
	public static readonly int MIN = 1;
	public static readonly int MAX = 20;

	private int charisma;
	public int Charisma
	{
		get { return charisma; }
		set { charisma = value < MIN ? MIN : value > MAX ? MAX : value; }
	}

	private int constitution;
	public int Constitution
	{
		get { return constitution; }
		set { constitution = value < MIN ? MIN : value > MAX ? MAX : value; }
	}

	private int dexterity;
	public int Dexterity
	{
		get { return dexterity; }
		set { dexterity = value < MIN ? MIN : value > MAX ? MAX : value; }
	}

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