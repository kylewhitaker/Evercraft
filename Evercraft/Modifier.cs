using System;

public class Modifier
{
	public int AddStrengthToRoll(int roll, int strength)
	{
		return roll + strength;
	}

	public int AddStrengthToDamage(int damage, int strength)
	{
		return damage + strength;
	}
}


