public class Abilities
{
	public int Charisma { get; set; }
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