using System;

namespace Evercraft
{
	public class Character
	{
		public string Name { get; set; }
		public Alignment Alignment { get; set; }
	}

	public enum Alignment
	{
		Good, Evil, Neutral
	}
}
