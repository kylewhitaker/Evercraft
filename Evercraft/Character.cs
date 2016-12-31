using System;

namespace Evercraft
{
	public class Character
	{
		public string Name { get; set; }
		public Alignment Alignment { get; set; }
		public int ArmorClass { get; set; }
		public int HitPoints { get; set; }

		public Character()
		{
			ArmorClass = 10;
			HitPoints = 5;
		}

		public int Attack(IRollDice die)
		{
			return die.Roll();
		}
}

	public enum Alignment
	{
		Good, Evil, Neutral
	}
}
