public class Abilities
{
	public static readonly int MIN = 1;
	public static readonly int MAX = 20;

	#region Fields
	private int charisma;
	private int constitution;
	private int dexterity;
	private int intelligence;
	private int strength;
	private int wisdom;
	#endregion

	#region Properties
	public int Charisma 
	{ 
		get { return charisma; } 
		set { charisma = withinRange(value); } 
	}
	public int Constitution
	{ 
		get { return constitution; } 
		set { constitution = withinRange(value); } 
	}
	public int Dexterity
	{
		get { return dexterity; }
		set { dexterity = withinRange(value); }
	}
	public int Intelligence
	{
		get { return intelligence; }
		set { intelligence = withinRange(value); }
	}
	public int Strength
	{
		get { return strength; }
		set { strength = withinRange(value); }
	}
	public int Wisdom
	{
		get { return wisdom; }
		set { wisdom = withinRange(value); }
	}
	#endregion

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

	private int withinRange(int val)
	{
		return val < MIN ? MIN : val > MAX ? MAX : val;
	}
}