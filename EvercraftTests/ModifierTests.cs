using NUnit.Framework;

public class ModifierTests
{
	[Test]
	public void AddStrengthToAttackRoll()
	{
		Modifier m = new Modifier();
		int roll = 15, strength = 2;
		Assert.AreEqual(roll + strength, m.AddStrengthToAttackRoll(roll, strength));

	}
}