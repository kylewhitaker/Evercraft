using NUnit.Framework;

public class ModifierTests
{
	[Test, Combinatorial]
	public void AddStrengthToRoll([Range(1,20)] int roll, [Range(-5,5)] int strength)
	{
		Modifier m = new Modifier();
		Assert.AreEqual(roll + strength, m.AddStrengthToRoll(roll, strength));
	}

	[Test, Combinatorial]
	public void AddStrengthToDamage([Range(1,2)] int damage, [Range(-5,5)] int strength)
	{
		Modifier m = new Modifier();
		Assert.AreEqual(damage + strength, m.AddStrengthToDamage(damage, strength));
	}
}