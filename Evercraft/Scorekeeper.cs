using System;

namespace Evercraft
{
	public class Scorekeeper
	{
		public void Damage(Character character, int points)
		{
			character.HitPoints -= points;
		}
	}
}