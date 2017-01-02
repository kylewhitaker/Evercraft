using System;

namespace Evercraft
{
	public class Umpire
	{
		public bool AttackIsHit(int roll, int armorClass)
		{
			return roll >= armorClass;
		}
	}
}