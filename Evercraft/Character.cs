using System;

public class Character
{
	public string Name { get; set; }
	public Alignment Alignment { get; set; }
	public int ArmorClass { get; set; }
	public int HitPoints { get; set; }
	public Abilities Abilities { get; set; }

	public Character()
	{
		Abilities = new Abilities();
		ArmorClass = 10;
		HitPoints = 5;
	}

	public int Attack(IRollDice die)
	{
		return die.Roll();
	}

	public bool IsDead()
	{
		return HitPoints <= 0;
	}
}

public enum Alignment
{
	Good, Evil, Neutral
}