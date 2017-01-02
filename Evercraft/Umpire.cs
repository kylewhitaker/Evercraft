using System;

public class Umpire
{
	public bool AttackIsHit(int roll, int armorClass)
	{
		return roll >= armorClass;
	}

	public bool AttackIsCriticalHit(int roll)
	{
		return true;
	}
}