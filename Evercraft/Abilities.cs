public class Abilities
{
	private const int MIN = 1;
	private const int MAX = 20;

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


	public int Constitution { get; set; }
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