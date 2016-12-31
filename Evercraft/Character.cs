using System;

namespace Evercraft
{
	public class Character
	{
		public string Name { get; set; }
		public Alignment Alignment { get; set; }
		public int ArmorClass { get; set; }

		public Character()
		{
			ArmorClass = 10;
		}
	}

	public enum Alignment
	{
		Good, Evil, Neutral
	}
}
